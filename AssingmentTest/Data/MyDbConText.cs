using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using AssingmentTest.Models;

namespace AssingmentTest.Data
{
    public class MyDbConText : DbContext
    {
        public MyDbConText() : base("ConnectionString")
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        
    }
}
