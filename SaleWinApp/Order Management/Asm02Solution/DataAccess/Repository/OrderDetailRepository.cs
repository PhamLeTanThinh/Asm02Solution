using BussinessObject.Models;
using DataAccess.DAO;
using DataAccess.IRepository;
using System.Collections.Generic;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private OrderDetailDAO _orderDetail = OrderDetailDAO.Instance;
        public void AddOrderDetail(OrderDetail _OrderDetail) => _orderDetail.AddOrderDetail(_OrderDetail);

        public IEnumerable<OrderDetail> FilterOrderDetailListByOrderId(int orderId) => _orderDetail.FilterOrderDetailListByOrderId(orderId);

        public IEnumerable<OrderDetail> FilterOrderDetailListByProductId(int productId) => _orderDetail.FilterOrderDetailListByProductId(productId);

        public OrderDetail GetOrderDetailById(int ProductId, int OrderId) => _orderDetail.GetOrderDetailById(ProductId, OrderId);

        public IEnumerable<OrderDetail> GetOrderDetailList() => _orderDetail.GetOrderDetailList();

        public void RemoveOrderDetail(OrderDetail _OrderDetail) => _orderDetail.RemoveOrderDetail(_OrderDetail);

        public void UpdateOrderDetail(OrderDetail _OrderDetail) => _orderDetail.UpdateOrderDetail(_OrderDetail);
    }
}
