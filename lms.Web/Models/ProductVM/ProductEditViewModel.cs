using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lms.Web.Models.ProductVM
{
    public class ProductEditViewModel
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        [Display(Name = "Category")]
        public int? CategoryId { get; set; }

        public List<SelectListItem> CategoryItemList { get; set; }


        public ICollection<global::lms.Model.Product> ProductList { get; set; }
    }
}
