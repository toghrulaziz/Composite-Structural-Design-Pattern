using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeStructuralPattern
{
    internal class PriceCalculator
    {
        public static decimal GetPriceProductList(List<Product> products)
        {
            decimal result = 0;

            foreach (Product product in products)
            {
                result += product.Price;
            }

            return result;
        }


        public static decimal GetPricePackageList(List<Package> packages)
        {
            decimal result = 0;

            foreach (Package package in packages)
            {
                result += package.getPrice();
            }

            return result;
        }

    }
}
