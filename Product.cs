using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WebShop
{
    public class Product
    {
        public Product(string name, string color, decimal price)
        {
            Name = name;
            Color = color;
            Price = price;
        }

        public string Name { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }

        public void ShowPoducts()
        {
            Console.WriteLine($"{Name}, Color:{Color}, Price{Price}");
        }
    }
}
