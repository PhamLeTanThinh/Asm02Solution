using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetOrders();
        void Add(Order order);
        void Update(Order order);
        void Delete(Order order);
        Order GetOrderById(int id);
        IEnumerable<Order> GetOrdersByMemberId(int memberId);
    }
}
