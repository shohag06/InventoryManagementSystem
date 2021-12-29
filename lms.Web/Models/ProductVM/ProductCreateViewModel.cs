using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lms.Web.Models.ProductVM
{
    public class ProductCreateViewModel
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        [Display(Name = "Category")]
        public int? CategoryId { get; set; }

    }
}
