using lms.Model;
using lms.Repository.Contracts;
using lms.Service.Base;
using lms.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace lms.Service
{
    public class OrderDetailService : BaseService<OrderDetail>, IOrderDetailService
    {
        private IOrderDetailRepository _repository;
        public OrderDetailService(IOrderDetailRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public ICollection<OrderDetail> getByOrderId(int id)
        {
            return _repository.getByOrderId(id);
        }
    }
}
