using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CompositeStructuralPattern
{
    internal class Product : Priceable
    {
        public string? Name { get; set; }
        public decimal Price { get; set; }


        public Product(string? name,decimal price)
        {
            Name = name;
            Price = price;
        }


        public decimal getPrice()
        {
            return this.Price;
        }
    }
}
