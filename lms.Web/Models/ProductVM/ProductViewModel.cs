using lms.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lms.Web.Models.ProductVM
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        [Display(Name = "Category")]
        public int? CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
