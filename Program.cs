using WebShop;

namespace Homework2_module2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome in I.HOUSE !!!");
            Console.WriteLine();
            var products = ProductFactory.GetDefaultProducts();
            for (int i = 0; i < products.Length; i++)
            {
                products[i].ShowPoducts();
            }

            Console.WriteLine();
            Basket basket = new Basket();
            Console.WriteLine();
            Console.WriteLine("Enter namber product, wich watn add to basket:");
            int x = int.Parse(Console.ReadLine()) - 1;
            basket.AddtoBasket(products[x]);
            Console.WriteLine("Enter namber product, wich watn add to basket:");
            int y = int.Parse(Console.ReadLine()) - 1;
            basket.AddtoBasket(products[y]);
            Console.WriteLine("Enter namber product, wich watn add to basket:");
            int z = int.Parse(Console.ReadLine()) - 1;
            basket.AddtoBasket(products[z]);
            Console.WriteLine();
            Console.WriteLine("Enter neme costomer:");
            string neme = Console.ReadLine();
            Console.WriteLine("Enter surneme costomer:");
            string surneme = Console.ReadLine();
            Console.WriteLine("Enter phone costomer:");
            string phone = Console.ReadLine();
            Costomer bob = new Costomer(phone, neme, surneme);
            Console.WriteLine();
            Order test = new Order(basket.BasketProduct, bob);
            basket.CleanBasket();
            test.PrintInfo();
        }
    }
}