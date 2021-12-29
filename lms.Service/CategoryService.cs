using lms.Model;
using lms.Repository.Contracts;
using lms.Service.Base;
using lms.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace lms.Service
{
    public class CategoryService:BaseService<Category>,ICategoryService
    {
        private ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository) : base(categoryRepository)
        {

        }
    }
}
