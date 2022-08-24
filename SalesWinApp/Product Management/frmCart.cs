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

namespace SalesWinApp
{
    public partial class frmCart : Form
    {
        IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        IOrderRepository orderRepository = new OrderRepository();
        IMemberRepository memberRepository = new MemberRepository();
        public frmCart()
        {
            InitializeComponent();
        }

        public List<Cart> CartList { get; set; }
        public Member Member { get; set; }


        //Load MemberName as MemberId

        void LoadMemberList()
        {
            try
            {
                var memberList = memberRepository.GetMember();
                cboxMemberId.DataSource = memberList;
                cboxMemberId.ValueMember = "MemberId";
                cboxMemberId.DisplayMember = "MemberName";
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Member list");
            }
        }
        private void frmCart_Load(object sender, EventArgs e)
        {
            dgvCart.DataSource = null;
            dgvCart.DataSource = CartList;
            dgvCart.Columns["Product"].Visible = false;
            LoadMemberList();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            List<OrderDetail> orderDetailsList = new List<OrderDetail>();

            if (CartList.Count == 0) {
                MessageBox.Show("Cart is empty!", "Cart Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var order = new Order
                {
                    OrderId = new Random().Next(999),
                    MemberId = Int32.Parse(cboxMemberId.Text),
                    OrderDate = DateTime.Now,
                    Freight = Int32.Parse(txtFreight.Text)
                };
                while (orderRepository.GetOrderById(order.OrderId) != null)
                {
                    order.OrderId = new Random().Next(999);
                }
                orderRepository.Add(order);

                foreach (Cart cartItem in CartList)
                {
                    var orderDetail = new OrderDetail
                    {
                        OrderId = order.OrderId,
                        ProductId = cartItem.Product.ProductId,
                        Quantity = cartItem.quantity,
                        UnitPrice = cartItem.Product.UnitPrice,
                    };
                    MessageBox.Show(orderDetail.OrderId + " " + orderDetail.ProductId + " " + orderDetail.Order + " " + orderDetail.Product);
                    order.OrderDetails.Add(orderDetail);
                    orderDetailsList.Add(orderDetail);
                }
                foreach (OrderDetail orderDetail in orderDetailsList)
                {
                    orderDetailRepository.Add(orderDetail);
                }
                CartList.Clear();
                MessageBox.Show("Checkout Success");
                this.DialogResult = DialogResult.OK;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           // CartList.Remove();
        }
    }
}
