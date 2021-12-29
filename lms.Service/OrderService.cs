using lms.Model;
using lms.Repository.Contracts;
using lms.Service.Base;
using lms.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace lms.Service
{
    public class OrderService : BaseService<Order>, IOrderService
    {

        private IOrderRepository _repository;
        public OrderService(IOrderRepository repository) : base(repository)
        {
            _repository = repository;
        }

     

        public Order GetByOrderDetails(int orderId)
        {
            return _repository.GetByOrderDetail(orderId);
        }

        public ICollection<Order> GetByOrder(int id)
        {
            return _repository.GetByOrder(id);
        }
    }
}
