using lms.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace lms.Service.Contracts
{
    public interface IOrderDetailService : IBaseService<OrderDetail>
    {
        ICollection<OrderDetail> getByOrderId(int id);
    }
}
