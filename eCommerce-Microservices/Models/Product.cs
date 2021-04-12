using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce_Microservices.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public string Image { get; set; }
        public ICollection<ProductCategory> ProductCategory { get; set; }
    }
}
