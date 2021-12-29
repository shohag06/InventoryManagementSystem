﻿using System;
using System.Collections.Generic;
using System.Text;

namespace lms.Model
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public double Qty { get; set; }
        public double UnitPrice { get; set; }
        public int DiscountPercentage { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int? OrderId { get; set; }
        public Order Order { get; set; }
    }
}
