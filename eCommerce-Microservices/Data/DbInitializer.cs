using eCommerce_Microservices.DAL;
using eCommerce_Microservices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce_Microservices.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ECommerceContext context)
        {
            // Look for any models.
            if (context.Models.Any())
            {
                return;   // DB has been seeded
            }

            var models = new Model[]
            {
                new Model{ModelName="model 1",Image="image 1",Price=float.Parse("15.6")},
                new Model{ModelName="model 2",Image="image 2",Price=float.Parse("15.6")},
                new Model{ModelName="model 3",Image="image 3",Price=float.Parse("15.6")},
                new Model{ModelName="model 4",Image="image 4",Price=float.Parse("15.6")},
                new Model{ModelName="model 5",Image="image 5",Price=float.Parse("15.6")},
                new Model{ModelName="model 6",Image="image 6",Price=float.Parse("15.6")}
            };

            context.Models.AddRange(models);
            context.SaveChanges();

            var products = new Product[]
            {
                new Product{ProductName="product 1", Image = "product image 1"},
                new Product{ProductName="product 2", Image = "product image 2"},
                new Product{ProductName="product 3", Image = "product image 3"},
                new Product{ProductName="product 4", Image = "product image 4"},
                new Product{ProductName="product 5", Image = "product image 5"},
                new Product{ProductName="product 6", Image = "product image 6"}
            };

            context.Products.AddRange(products);
            context.SaveChanges();

            var categories = new ProductCategory[]
            {
                new ProductCategory{CategoryName="Electronic" },
                new ProductCategory{CategoryName="Laptop" },
                new ProductCategory{CategoryName="Watches" },
                new ProductCategory{CategoryName="Clothes" }
            };

            context.ProductCategories.AddRange(categories);
            context.SaveChanges();
        }
    }
}
