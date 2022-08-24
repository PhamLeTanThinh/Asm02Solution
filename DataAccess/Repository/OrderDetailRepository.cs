using BussinessObject.Context;
using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public void Add(OrderDetail orderDetail)
        {
            try
            {
                using (var fsContext = new SaleManagementContext())
                {
                    fsContext.OrderDetails.Add(orderDetail);

                    fsContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Delete(OrderDetail orderDetail)
        {
            try
            {
                using (var fsContext = new SaleManagementContext())
                {
                    var _orderDetail = fsContext.OrderDetails.SingleOrDefault(value => (value.OrderId == orderDetail.OrderId && value.ProductId == orderDetail.ProductId));
                    fsContext.OrderDetails.Remove(_orderDetail);
                    fsContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public IEnumerable<OrderDetail> GetOrderDetails()
        {
            IEnumerable<OrderDetail> orderDetails;

            try
            {
                using (var fsContext = new SaleManagementContext())
                {
                    orderDetails = fsContext.OrderDetails.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orderDetails;
        }
        public IEnumerable<OrderDetail> GetOrderDetailsByOrder(Order order)
        {
            IEnumerable<OrderDetail> orderDetailList = GetOrderDetails();
            IEnumerable<OrderDetail> orderDetailList_Sub = orderDetailList.Where(x => x.OrderId == order.OrderId).ToList();
            return orderDetailList_Sub;
        }
        public void Update(OrderDetail orderDetail)
        {
            try
            {
                using (var fsContext = new SaleManagementContext())
                {
                    fsContext.Entry<OrderDetail>(orderDetail).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    fsContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public OrderDetail GetOrderDetailById(Order order, int productId)
        {
            IEnumerable<OrderDetail> orderDetailList = GetOrderDetails();
            OrderDetail orderDetail = orderDetailList.SingleOrDefault(value => (value.OrderId == order.OrderId && value.ProductId == productId));
            return orderDetail;
        }
    }
}
