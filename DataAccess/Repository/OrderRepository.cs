using BussinessObject.Context;
using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository: IOrderRepository
    {
        public void Add(Order order)
        {
            try
            {
                using (var context = new SaleManagementContext())
                {
                    context.Orders.Add(order);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Delete(Order order)
        {
            try
            {
                using (var fsContext = new SaleManagementContext())
                {
                    var _order = fsContext.Orders.FirstOrDefault(value => value.OrderId == order.OrderId);
                    fsContext.Orders.Remove(_order);
                    fsContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public IEnumerable<Order> GetOrders()
        {
            IEnumerable<Order> orders;

            try
            {
                using (var context = new SaleManagementContext())
                {
                    orders = context.Orders.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orders;
        }
        public IEnumerable<Order> GetOrdersByMemberId(int memberId)
        {
            IEnumerable<Order> orders = GetOrders();
            List<Order> orders_Sub = orders.Where(orderSub => orderSub.MemberId == memberId).ToList();
            return orders_Sub;
        }
        public void Update(Order order)
        {
            try
            {
                using (var context = new SaleManagementContext())
                {
                    context.Entry<Order>(order).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Order GetOrderById(int id)
        {
            IEnumerable<Order> orders = GetOrders();
            Order order = orders.SingleOrDefault(orderSub => orderSub.OrderId == id);
            return order;
        }
    }
}
