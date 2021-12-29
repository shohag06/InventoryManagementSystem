using lms.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace lms.Repository.Contracts
{
    public interface IOrderRepository : IRepository<Order>
    {
        Order GetByOrderDetail(int orderId);
        ICollection<Order> GetByOrder(int id);
    }
}
