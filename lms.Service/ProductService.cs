using lms.Model;
using lms.Repository.Contracts;
using lms.Service.Base;
using lms.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace lms.Service
{
    public class ProductService : BaseService<Product>, IProductService
    {

        private IProductRepository _productRepository;
        public ProductService(IProductRepository repository) : base(repository)
        {
            _productRepository = repository;
        }

        //public ICollection<Product> GetByYear(int year)
        //{
        //    throw new NotImplementedException();
        //}

        public ICollection<Product> GetByCategory(int categoryId)
        {
            var products = _productRepository.GetByCategory(categoryId);

            return products;
        }
    }
}
