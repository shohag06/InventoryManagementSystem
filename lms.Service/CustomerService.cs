using Ims.Data;
using lms.Model;
using lms.Repository.Contracts;
using lms.Service.Base;
using lms.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace lms.Service
{
    public class CustomerService : BaseService<Customer>, ICustomerService
    {
       
        //private readonly ApplicationDbContext _db;
        //public CustomerService(ApplicationDbContext db) : base(db)
        //{
        //    _db = db;
        //}
        private ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository repository) : base(repository)
        {
            _customerRepository = repository;
        }

    }
}
