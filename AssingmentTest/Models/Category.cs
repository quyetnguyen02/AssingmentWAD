using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AssingmentTest.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string CateName { get; set; }

        public virtual IEnumerable<Product> Products { get; set; }
    }
}