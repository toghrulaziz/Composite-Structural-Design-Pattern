using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeStructuralPattern
{
    internal class Package : Priceable
    {
        public string? Name { get; set; }
        public List<Product>? Products { get; set; }


        public Package(string? name)
        {
            Name = name;
            Products = new List<Product>();
        }

        public decimal getPrice()
        {
            return PriceCalculator.GetPriceProductList(Products);
        }
    }
}
