using Ims.Data;
using lms.Model;
using lms.Model.ViewModels;
using lms.Repository.Base;
using lms.Repository.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lms.Repository
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        private readonly ApplicationDbContext _db;
        public OrderRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public ICollection<VWOrderInfo> GetAllOrderSummary()
        {
            return _db.VwOrderInfos.ToList();
        }

        public override Order GetById(int id)
        {


            return _db.Orders
                .Include(c => c.OrderDetails)
                .ThenInclude(c => c.Product)
                .FirstOrDefault(c => c.Id == id);
        }

        public Order GetByOrderDetail(int orderId)
        {
            return _db.Orders
                .Include(c => c.OrderDetails)
                    .ThenInclude(c => c.Product)
                .FirstOrDefault(c => c.Id == orderId);
        }

        public ICollection<Order> GetByOrder(int id)
        {
            return _db.Orders
                .Where(c => c.Id == id)
                .Include(c => c.OrderDetails)
                //.Include(c=>c.Customer)
                .ToList();
        }

        public override ICollection<Order> GetAll()
        {
            return _db.Orders.Include(c => c.OrderDetails).ToList();
        }


    }
}
