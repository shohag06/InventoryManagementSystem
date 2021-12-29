using lms.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace lms.Service.Contracts
{
    public interface IProductService : IBaseService<Product>
    {
        //ICollection<Product> GetByYear(int year);

        ICollection<Product> GetByCategory(int categoryId);
    }
}
