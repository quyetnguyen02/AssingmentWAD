using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AssingmentTest.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string ProName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public virtual Category category { get; set; }
    }
}