using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    public class BasketManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Congratulations! Your product added the basket : " + product.ProductName);
        }

        public void Add2(string productName, string description, double price)
        {
            Console.WriteLine("Congratulations! Your product added the basket : " + productName);
        }
    }
}
