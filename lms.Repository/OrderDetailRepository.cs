using Ims.Data;
using lms.Model;
using lms.Repository.Base;
using lms.Repository.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lms.Repository
{
    public class OrderDetailRepository : Repository<OrderDetail>, IOrderDetailRepository
    {
        private readonly ApplicationDbContext _db;
        public OrderDetailRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public ICollection<OrderDetail> getByOrderId(int id)
        {
            return _db.OrderDetails
                .Where(c => c.OrderId == id)
                .Include(c => c.Product)
                .Include(c => c.Order)
                .ToList();
        }
    }
}
