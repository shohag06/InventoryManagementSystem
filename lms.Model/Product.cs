using System;
using System.Collections.Generic;
using System.Text;

namespace lms.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
