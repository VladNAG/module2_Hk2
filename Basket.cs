using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop
{
    public class Basket
    {
        public Basket()
        {
            BasketProduct = new Product[10];
            Count = 0;
        }

        public Product[] BasketProduct { get; private set; }
        public int Count { get; private set; }

        public void AddtoBasket(Product product)
        {
            BasketProduct[Count] = product;
            Count++;
            Console.WriteLine($"Product {product.Name} add to Basket");
        }

        public void CleanBasket()
        {
            BasketProduct = new Product[10];
            Count = 0;
        }
    }
}
