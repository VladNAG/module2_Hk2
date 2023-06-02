using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop
{
    internal class ProductFactory
    {
        public static Product[] GetDefaultProducts()
         {
            var products = new Product[10];
            products[0] = new Product("1) X", "Black", 850);
            products[1] = new Product("2) X", "White", 850);
            products[2] = new Product("3) X", "Red", 850);
            products[3] = new Product("4) XR", "Black", 950);
            products[4] = new Product("5) XR", "White", 950);
            products[5] = new Product("6) XR", "Red", 950);
            products[6] = new Product("7) 11", "Black", 1050);
            products[7] = new Product("8) 11", "White", 1050);
            products[8] = new Product("9) 12", "Black", 1150);
            products[9] = new Product("10) 12", "White", 1150);

            return products;
        }
    }
}
