using AutoMapper;
using lms.Model;
using lms.Web.Models.ProductVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lms.Web.AutomapperConfiguration
{
    public class AutomapperProfile:Profile
    {
        public AutomapperProfile()
        {
            CreateMap<ProductCreateViewModel, Product>();
            CreateMap<Product, ProductCreateViewModel>();
            CreateMap<ProductEditViewModel, Product>();
            CreateMap<Product, ProductEditViewModel>();
            CreateMap<Product, ProductViewModel>();


        }
    }
}
