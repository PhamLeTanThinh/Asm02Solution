using BussinessObject.Models;
using DataAccess.DAO;
using DataAccess.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private OrderDAO _orderDAO = OrderDAO.Instance;
        public void AddOrder(Order _Order) => _orderDAO.AddOrder(_Order);
        public IEnumerable<Order> FilterOrderListByDateTime(DateTime _from, DateTime _to) => _orderDAO.FilterOrderListByDateTime(_from, _to);
        public IEnumerable<Order> FilterOrderListByMemberId(int MemberId) => _orderDAO.FilterOrderListByMemberId(MemberId);
        public Order GetOrderById(int id) => _orderDAO.GetOrderById(id);
        public IEnumerable<Order> GetOrderList() => _orderDAO.GetOrderList();
        public void RemoveOrder(Order _Order) => _orderDAO.RemoveOrder(_Order);
        public void UpdateOrder(Order _Order) => _orderDAO.UpdateOrder(_Order);
    }
}
