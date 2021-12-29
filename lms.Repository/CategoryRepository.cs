using Ims.Data;
using lms.Model;
using lms.Repository.Base;
using lms.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace lms.Repository
{
    public class CategoryRepository:Repository<Category>,ICategoryRepository
    {
     
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
