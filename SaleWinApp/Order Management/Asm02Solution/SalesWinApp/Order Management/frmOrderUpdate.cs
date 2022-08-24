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
    public partial class frmOrderUpdate : Form
    {
        ProductRepository _productRepository = new ProductRepository();
        IEnumerable<Product> _productList = new List<Product>();
        OrderDetailRepository _orderDetailRepository = new OrderDetailRepository();
        List<OrderDetail> _orderDetailList_New = new List<OrderDetail>();
        IEnumerable<OrderDetail> _orderDetailList_Old = new List<OrderDetail>();
        MemberRepository _memberRepository = new MemberRepository();
        IEnumerable<Member> _memberList = new List<Member>();
        OrderRepository _orderRepository = new OrderRepository();
        public frmOrderUpdate(Order _order)
        {
            InitializeComponent();
            this.AutoLoadDataIntoCBMember();
            this.LoadDataIntoInputs(_order);
            this.AutoLoadDataIntoCBProduct();
            this.InitOderDetailList();
            this.AutoLoadDataIntoDgvProduct();
            this.DisableInputsOrderDetail();
        }

        private void btnAddOrderDetail_Click(object sender, EventArgs e)
        {
            if (btnAddOrderDetail.Text.Contains("Add"))
            {
                this.EnableInputsOrderDetail();
                btnCancelOrderDetail.Enabled = true;
                btnAddOrderDetail.Text = "Save Order Detail";
            }
            else
            {
                if (cboProduct.SelectedIndex < 0 || mtxtQuantity.Text.Equals(""))
                {
                    MessageBox.Show("Invalud Input.");
                }
                else
                {
                    var _tempProduct = (Product)cboProduct.SelectedItem;
                    int i = 0;
                    foreach (var _orderDetail in _orderDetailList_New)
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
                        var _orderDetail = _orderDetailList_New.Find(x => x.ProductId == _tempProduct.ProductId);
                        int j = Int32.Parse(mtxtQuantity.Text.Trim());
                        int result = _orderDetail.Quantity + j;
                        _orderDetail.Quantity = result;
                        this.AutoLoadDataIntoDgvProduct();
                    }
                    else
                    {
                        var _tempOrderDetail = new OrderDetail();
                        _tempOrderDetail.ProductId = _tempProduct.ProductId;
                        _tempOrderDetail.OrderId = Int32.Parse(mtxtOrderId.Text.Trim().ToString());
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
            _dialogResult = MessageBox.Show("Do you really want to delete chosen Order Detail?", "Management", (MessageBoxButtons)MessageBoxDefaultButton.Button1);
            if (_dialogResult == DialogResult.OK)
            {
                foreach (var item in dgvOrderDetails.SelectedRows)
                {
                    _orderDetailList_New.RemoveAt(dgvOrderDetails.CurrentCell.RowIndex);
                }
                this.AutoLoadDataIntoDgvProduct();
                MessageBox.Show("Deleted the chosen order Detail.");
            }
        }

        private void btnCancelOrderDetail_Click(object sender, EventArgs e)
        {
            this.ClearInputsOrderDetail();
            this.DisableInputsOrderDetail();
            btnCancelOrderDetail.Enabled = false;
            btnAddOrderDetail.Text = "Add an Order Detail";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboMember.SelectedIndex < 0 || mtxtFreight.Text.Equals(""))
            {
                MessageBox.Show("Invalid Input.");
            }
            else if (_orderDetailList_New.Count < 1)
            {
                MessageBox.Show("Order Detail List must not be empty.");
            }
            else
            {
                var _tempOrder = _orderRepository.GetOrderById(Int32.Parse(mtxtOrderId.Text.ToString()));
                var _tempMember = (Member)cboMember.SelectedItem;
                _tempOrder.MemberId = _tempMember.MemberId;
                _tempOrder.OrderDate = DateTime.Parse(dtpOrderDate.Value.ToString());
                _tempOrder.RequiredDate = DateTime.Parse(dtpRequiredDate.Value.ToString());
                _tempOrder.ShippedDate = DateTime.Parse(dtpShippedDate.Value.ToString());
                _tempOrder.Freight = decimal.Parse(mtxtFreight.Text);
                _orderRepository.UpdateOrder(_tempOrder);

                // save List
                var _tempOrderDetailList = _orderDetailList_New.Except(_orderDetailList_Old);
                foreach (var _tempOrderDetail in _tempOrderDetailList)
                {
                    _orderDetailRepository.AddOrderDetail(_tempOrderDetail);
                }
                this.Close();
                MessageBox.Show("Updated successfully.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var _tempOrder = _orderRepository.GetOrderById(Int32.Parse(mtxtOrderId.Text.ToString()));
            this.LoadDataIntoInputs(_tempOrder);
        }

        private void cboMember_TextChanged(object sender, EventArgs e)
        {
            _memberList = _memberRepository.FilterMemberByString(cboMember.Text);
            this.LoadDataIntoCBMember(_memberList);
        }

        #region [ Load Data functions ]
        private void cboProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvOrderDetails.Rows.Clear();
            foreach (var _orderDetail in _orderDetailList_New)
            {
                var tempProduct = _productRepository.GetProductById(_orderDetail.ProductId);
                dgvOrderDetails.Rows.Add(tempProduct, _orderDetail.UnitPrice, _orderDetail.Quantity, _orderDetail.Discount);
            }
        }

        private void AutoLoadDataIntoDgvProduct()
        {
            dgvOrderDetails.Rows.Clear();
            foreach (var _orderDetail in _orderDetailList_New)
            {
                var tempProduct = _productRepository.GetProductById(_orderDetail.ProductId);
                dgvOrderDetails.Rows.Add(tempProduct, _orderDetail.UnitPrice, _orderDetail.Quantity, _orderDetail.Discount);
            }
        }

        public void AddDgvOrderDetailRow(OrderDetail _orderDetail)
        {
            _orderDetailList_New.Add(_orderDetail);
            this.AutoLoadDataIntoDgvProduct();
        }

        public void LoadDataIntoInputs(Order _order)
        {
            var index = GetMemberIndex(_order);
            mtxtOrderId.Text = _order.OrderId.ToString();
            cboMember.SelectedIndex = index;
            dtpOrderDate.Text = _order.OrderDate.ToString();
            dtpRequiredDate.Text = _order.RequiredDate.ToString();
            dtpShippedDate.Text = _order.ShippedDate.ToString();
            var _tempFreightString = _order.Freight.ToString();
            mtxtFreight.Text = _tempFreightString.Remove(_tempFreightString.Length - 5);
        }

        public void AutoLoadDataIntoCBMember()
        {
            _memberList = _memberRepository.GetMemberList();
            this.LoadDataIntoCBMember(_memberList);
        }

        public void LoadDataIntoCBMember(IEnumerable<Member> _memberList)
        {
            cboMember.Items.Clear();
            foreach (var member in _memberList)
            {
                cboMember.Items.Add(member);
            }
        }

        public int GetMemberIndex(Order _order)
        {
            int count = 0;
            var _tempMember = _memberRepository.GetMemberById(_order.MemberId);
            _memberList = _memberRepository.GetMemberList();
            foreach (var member in _memberList)
            {
                if (_tempMember.MemberId == member.MemberId)
                {
                    return count;
                }
                else
                {
                    count++;
                }
            }
            return count;
        }

        public void AutoLoadDataIntoCBProduct()
        {
            _productList = _productRepository.GetProductList();
            foreach (var _product in _productList)
            {
                cboProduct.Items.Add(_product);
            }
        }
        #endregion

        #region [ input functinos ]
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
        #endregion

        private void InitOderDetailList()
        {
            _orderDetailList_Old = _orderDetailRepository.FilterOrderDetailListByOrderId(Int32.Parse(mtxtOrderId.Text.Trim()));
            _orderDetailList_New.AddRange(_orderDetailList_Old);
        }
    }
}