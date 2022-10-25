using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductName = "Elma";
            product1.Price = 15;
            product1.Description = "Amasya Elması";
            product1.StockQuantity = 67;

            Product product2 = new Product();
            product2.ProductName = "Karpuz";
            product2.Price = 80;
            product2.Description = "Diyarbakır Karpuzu";
            product2.StockQuantity = 25;

            Product[] products = new Product[] {product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.ProductName);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Description);
                Console.WriteLine("------------");

            }
            Console.WriteLine("---------Methods---------");

            BasketManager basketmanager = new BasketManager();
            basketmanager.Add(product1);
            basketmanager.Add(product2);
            basketmanager.Add2("Armut", "Yeşil Armut", 12);
        }
    }
}

