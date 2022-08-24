using BussinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp.Order_Management
{
    public partial class frmOrderCreate : Form
    {
        OrderDetailRepository _orderDetailRepository = new OrderDetailRepository();
        ProductRepository _productRepository = new ProductRepository();
        IEnumerable<Product> _productList = new List<Product>();
        MemberRepository _memberRepository = new MemberRepository();
        OrderRepository _orderRepository = new OrderRepository();
        IEnumerable<Member> _memberList = new List<Member>();
        List<OrderDetail> _orderDetailList = new List<OrderDetail>();
        public frmOrderCreate()
        {
            InitializeComponent();
            this.AutoLoadDataIntoCB();
            this.AutoLoadDataIntoCBProduct();
            this.DisableInputsOrderDetail();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var _tempOrder = _orderRepository.GetOrderById(Int32.Parse(mtxtOrderId.Text.ToString()));
            if (mtxtOrderId.Text.ToString().Equals("")
                || cboMember.SelectedIndex < 0
                || mtxtFreight.Text.ToString().Equals(""))
            {
                MessageBox.Show("Invalid Input.");
            }
            else if (_tempOrder != null)
            {
                MessageBox.Show("Order Id Cannot be dupplicated.");
            }
            else
            {
                if (_orderDetailList.Count == 0)
                {
                    MessageBox.Show("Empty Order Detail List");
                }
                else
                {
                    // save order first
                    var _temp = new Order();
                    _temp.OrderId = Int32.Parse(mtxtOrderId.Text.Trim().ToString());
                    var _tempMember = (Member)cboMember.SelectedItem;
                    _temp.MemberId = _tempMember.MemberId;
                    _temp.OrderDate = DateTime.Parse(dtpOrderDate.Value.ToLongTimeString());
                    _temp.RequiredDate = DateTime.Parse(dtpRequiredDate.Value.ToLongTimeString());
                    _temp.ShippedDate = DateTime.Parse(dtpShippedDate.Value.ToLongTimeString());
                    _temp.Freight = decimal.Parse(mtxtFreight.Text.Trim());
                    _orderRepository.AddOrder(_temp);
      
                    foreach (var _tempDetail in _orderDetailList)
                    {
                        _tempDetail.OrderId = _temp.OrderId;
                        _orderDetailRepository.AddOrderDetail(_tempDetail);
                    }
                    this.Close();
                    MessageBox.Show("Added succesfully");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.ClearInputsOrder();
        }

        private void btnAddOrderDetail_Click(object sender, EventArgs e)
        {
            if (btnAddOrderDetail.Text.Contains("Add"))
            {
                this.EnableInputsOrderDetail();
                btnCancelOrderDetail.Enabled = true;
                btnAddOrderDetail.Text = "Save";
            }
            else
            {
                if (cboProduct.SelectedIndex < 0
                    || mtxtQuantity.Text.Equals(""))
                {
                    MessageBox.Show("Invalud Input.");
                }
                else
                {

                    var _tempOrderDetail = new OrderDetail();
                    var _tempProduct = (Product)cboProduct.SelectedItem;
                    int i = 0;
                    foreach (var _orderDetail in _orderDetailList)
                    {
                        if (_orderDetail.ProductId == _tempProduct.ProductId)
                        {
                            i = 1;
                            break;
                        }
                        else
                        {
                            i = 2;
                        }
                    }
                    if (i == 1)
                    {
                        var _orderDetail = _orderDetailList.Find(x => x.ProductId == _tempProduct.ProductId);
                        int j = Int32.Parse(mtxtQuantity.Text.Trim());
                        int result = _orderDetail.Quantity + j;
                        _orderDetail.Quantity = result;
                        this.AutoLoadDataIntoDgvProduct();
                    }
                    else
                    {
                        _tempOrderDetail.ProductId = _tempProduct.ProductId;
                        _tempOrderDetail.UnitPrice = _tempProduct.UnitPrice;
                        _tempOrderDetail.Quantity = Int32.Parse(mtxtQuantity.Text.Trim());
                        if (mtxtDiscount.Text.Equals(""))
                        {
                            _tempOrderDetail.Discount = (double)0;
                        }
                        else
                        {
                            _tempOrderDetail.Discount = double.Parse(mtxtDiscount.Text.Trim());
                        }
                        this.AddDgvOrderDetailRow(_tempOrderDetail);
                    }

                    btnCancelOrderDetail.Enabled = false;
                    btnAddOrderDetail.Text = "Add an Order Detail";
                    this.DisableInputsOrderDetail();
                    this.ClearInputsOrderDetail();
                }
            }
        }

        private void btnDeleteOrderDetail_Click(object sender, EventArgs e)
        {
            DialogResult _dialogResult;
            _dialogResult = MessageBox.Show("Do you really want to delete chosen Order?", "Management", (MessageBoxButtons)MessageBoxDefaultButton.Button1);
            if (_dialogResult == DialogResult.OK)
            {
                foreach (DataGridViewRow item in dgvOrderDetails.SelectedRows)
                {
                    dgvOrderDetails.Rows.RemoveAt(item.Index);
                }
                this.AutoLoadDataIntoDgvProduct();
                MessageBox.Show("Deleted the chosen order.");
            }
        }

        private void btnCancelOrderDetail_Click(object sender, EventArgs e)
        {
            this.ClearInputsOrderDetail();
            this.DisableInputsOrderDetail();
            btnCancelOrderDetail.Enabled = false;
            btnAddOrderDetail.Text = "Add an Order Detail";
        }
        private void AutoLoadDataIntoDgvProduct()
        {
            dgvOrderDetails.Rows.Clear();
            foreach (var _orderDetail in _orderDetailList)
            {
                var tempProduct = _productRepository.GetProductById(_orderDetail.ProductId);
                dgvOrderDetails.Rows.Add(tempProduct, _orderDetail.UnitPrice, _orderDetail.Quantity, _orderDetail.Discount);
            }
        }

        public void AddDgvOrderDetailRow(OrderDetail _orderDetail)
        {
            _orderDetailList.Add(_orderDetail);
            this.AutoLoadDataIntoDgvProduct();
        }

        private void cboProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProduct.SelectedIndex > -1)
            {
                var _tempProduct = (Product)cboProduct.SelectedItem;
                txtUnitPrice.Text = _tempProduct.UnitPrice.ToString();
            }
            else
            {
                txtUnitPrice.Clear();
            }
        }
        public void DisableInputsOrderDetail()
        {
            cboProduct.Enabled = false;
            mtxtDiscount.Enabled = false;
            mtxtQuantity.Enabled = false;
        }

        public void EnableInputsOrderDetail()
        {
            cboProduct.Enabled = true;
            mtxtDiscount.Enabled = true;
            mtxtQuantity.Enabled = true;
        }
        public void ClearInputsOrderDetail()
        {
            cboProduct.SelectedIndex = -1;
            mtxtDiscount.Clear();
            mtxtQuantity.Clear();
        }
        public void ClearInputsOrder()
        {
            mtxtOrderId.Clear();
            cboMember.SelectedIndex = -1;
            dtpOrderDate.Value = DateTime.Now;
            dtpRequiredDate.Value = DateTime.Now;
            dtpShippedDate.Value = DateTime.Now;
            mtxtFreight.Clear();
        }
        public void AutoLoadDataIntoCBProduct()
        {
            _productList = _productRepository.GetProductList();
            foreach (var _product in _productList)
            {
                cboProduct.Items.Add(_product);
            }
        }
        public void AutoLoadDataIntoCB()
        {
            _memberList = _memberRepository.GetMemberList();
            this.LoadDataIntoCB(_memberList);
        }
        public void LoadDataIntoCB(IEnumerable<Member> _memberList)
        {
            cboMember.Items.Clear();
            foreach (var member in _memberList)
            {
                cboMember.Items.Add(member);
            }
        }
    }
}
