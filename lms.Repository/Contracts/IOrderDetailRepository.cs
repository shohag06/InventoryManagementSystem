using lms.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace lms.Repository.Contracts
{
    public interface IOrderDetailRepository : IRepository<OrderDetail>
    {
        ICollection<OrderDetail> getByOrderId(int id);
    }
}
