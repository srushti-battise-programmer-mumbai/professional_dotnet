// Program to demonstrate Interface With Collections in C# using Visual Studio.
// Programmer: Srushti Battise

namespace InterfaceWithCollections_01
{
    using System;
    using System.Collections.Generic;
    public interface IProduct
    {
        string Name { get; }
        double Price { get; }
    }
    public class Product : IProduct
    {
        public string Name { get; private set; }
        public double Price { get; private set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Program to demonstrate Interface With Collections in C# using Visual Studio.\n");
            List<IProduct> products = new List<IProduct>
            {
                new Product("Laptop", 1500),
                new Product("Tablet", 800)
            };

            foreach (IProduct product in products)
            {
                Console.WriteLine("Product: " + product.Name + ", Price: $" + product.Price);
            }
        }
    }
}