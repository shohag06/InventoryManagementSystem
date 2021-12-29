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
    public class ProductRepository:Repository<Product>,IProductRepository
    {
        private readonly ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public override ICollection<Product> GetAll()
        {
            return _db.Products.Include(c => c.Category).ToList();
        }

        public ICollection<Product> GetByCategory(int categoryId)
        {
            return _db.Products.Where(c => c.CategoryId == categoryId).ToList();
        }
    }
}
