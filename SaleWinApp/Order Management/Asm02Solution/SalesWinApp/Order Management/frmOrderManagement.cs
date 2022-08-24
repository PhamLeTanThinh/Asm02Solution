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
    public partial class frmOrderManagement : Form
    {
        OrderRepository _orderRepository = new OrderRepository();
        IEnumerable<Order> _orderList = new List<Order>();
        MemberRepository _memberRepository = new MemberRepository();
        public frmOrderManagement()
        {
            InitializeComponent();
            this.AutoLoadDataIntoDgv();
            dtpFromDate.Value = DateTime.Now;
            dtpToDate.Value = DateTime.Now;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            this.AutoLoadDataIntoDgv();
        }

        #region [DGV - functions]
        public void AutoLoadDataIntoDgv()
        {
            _orderList = _orderRepository.GetOrderList();

            this.LoadDataIntoDgv(_orderList);
        }

        public void LoadDataIntoDgv(IEnumerable<Order> _orderList)
        {
            dgvOrder.Rows.Clear();
            foreach (var order in _orderList)
            {
                var _tempMemberEmail = _memberRepository.GetMemberById(order.MemberId).Email;
                dgvOrder.Rows.Add(order.OrderId, _tempMemberEmail, order.OrderDate.ToString("ddd, dd MMM, yyyy"), order.RequiredDate.ToString("ddd, dd MMM, yyyy"), order.ShippedDate.ToString("ddd, dd MMM, yyyy"), order.Freight);
            }
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOrder.SelectedRows.Count == 1)
            {
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
            }
        }
        #endregion

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmOrderCreate frmCreate = new frmOrderCreate();
            frmCreate.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var _tempOrder = _orderRepository.GetOrderById(Int32.Parse(dgvOrder.SelectedRows[0].Cells[0].Value.ToString()));
            frmOrderUpdate frmOrderUpdate = new frmOrderUpdate(_tempOrder);
            frmOrderUpdate.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult _dialogResult;
            _dialogResult = MessageBox.Show("Do you really want to delete chosen Order?", "Management", (MessageBoxButtons)MessageBoxDefaultButton.Button1);
            if (_dialogResult == DialogResult.OK)
            {
                var temp = _orderRepository.GetOrderById(Int32.Parse(dgvOrder.SelectedRows[0].Cells[0].Value.ToString()));
                _orderRepository.RemoveOrder(temp);
                this.AutoLoadDataIntoDgv();
                MessageBox.Show("Deleted the chosen order.");
            }
        }
    }
}
