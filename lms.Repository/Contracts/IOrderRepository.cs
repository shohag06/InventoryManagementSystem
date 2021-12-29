using lms.Model;
using lms.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace lms.Repository.Contracts
{
    public interface IOrderRepository : IRepository<Order>
    {
        ICollection<VWOrderInfo> GetAllOrderSummary();
        Order GetByOrderDetail(int orderId);
        ICollection<Order> GetByOrder(int id);
    }
}
