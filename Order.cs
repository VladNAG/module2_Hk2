using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop
{
    public class Order
    {
        public Order(Product[] products, Costomer castomer)
        {
            Products = products;
            Castomer = castomer;
            Count = 0;
        }

        public Product[] Products { get; private set; }
        public Costomer Castomer { get; private set; }
        public decimal Price { get; private set; }
        public int Count { get; private set; }
        public void PrintInfo()
        {
            Console.WriteLine($"Mr {Castomer.NameСustomer}, Thank you for ordering");
            Random random = new Random();
            int nambOrder = random.Next(300, 1000);
            Console.WriteLine($"Namber order: {nambOrder.ToString()}");
            for (int i = 0; i < Products.Length; i++)
            {
                var product = Products[i];
                if (product == null)
                {
                    continue;
                }

                Price += Products[i].Price;
                Count++;
            }

            Console.WriteLine($"Count products:{Count}");
            Console.WriteLine($"Total order:{Price}");
        }
    }
}
