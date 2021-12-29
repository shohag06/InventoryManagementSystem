using lms.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace lms.Repository.Contracts
{
    public interface IProductRepository : IRepository<Product>
    {
        ICollection<Product> GetByCategory(int categoryId);
    }
}
