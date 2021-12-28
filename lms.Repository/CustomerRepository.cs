using Ims.Data;
using lms.Model;
using lms.Repository.Base;
using lms.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace lms.Repository
{
    public class CustomerRepository: Repository<Customer>, ICustomerRepository
    {
        private readonly ApplicationDbContext _db;
        public CustomerRepository(ApplicationDbContext db):base(db)
        {
            _db = db;
        }
    }
}
