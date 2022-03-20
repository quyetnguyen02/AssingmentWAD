namespace AssingmentTest.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using AssingmentTest.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<AssingmentTest.Data.MyDbConText>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AssingmentTest.Data.MyDbConText context)
        {
            context.Products.AddOrUpdate(x => x.ID,
                   new Product()
                   {
                       ID = 1,
                       ProName = "Pride and Prejudice",
                       Price = 18.13,
                       Quantity=20,
                      
                       category = new Category() { ID = 1, CateName = "Hat" },
                   },
                      new Product()
                      {
                          ID = 2,
                          ProName = "Pride and Prejudice",
                          Price = 18.13,
                          Quantity = 20,
                          category = new Category() { ID = 2, CateName = "Hat" },
                      },
                  new Product()
                  {
                      ID = 13,
                      ProName = "Pride and Prejudice",
                      Price = 18.13,
                      Quantity = 20,
                      category = new Category() { ID = 3, CateName = "Hat" },
                  }

                   );
        }
    }
}
