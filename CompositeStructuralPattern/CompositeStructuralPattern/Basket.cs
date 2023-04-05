using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeStructuralPattern
{
    internal class Basket
    {
        public string? Name { get; set; }
        public List<Priceable>? PriceableList { get; set; }


        public Basket(string? name)
        {
            Name = name;
            PriceableList = new List<Priceable>();
        }


        public decimal TotalPrice()
        {
            decimal result = 0;

            foreach (var priceable in PriceableList)
            {
                result += priceable.getPrice();
            }

            return result;
        }

    }
}
