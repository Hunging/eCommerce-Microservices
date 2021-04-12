using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce_Microservices.Models
{
    public class Model
    {
        public int ID { get; set; }
        public string ModelName { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }
        public ICollection<Product> Product { get; set; }
    }
}
