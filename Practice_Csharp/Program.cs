using System.Collections;
using System;
using System.Collections.Generic;

namespace Practice
{
    public class Product
    {
        static void Main(string[] args)
        {
            GetSampleProducts().Print();
        }
        string name;
        public string Name
        {
            get
            {
                return name;
            }
        }

        decimal price;
        public decimal Price
        {
            get
            {
                return price;
            }
        }

        public Product(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        public static List<Product> GetSampleProducts()
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("West Side Story", 9.99m));
            list.Add(new Product("Assassins", 14.99m));
            list.Add(new Product("Frogs", 13.99m));
            list.Add(new Product("Sweeney Todd", 10.99m));
            return list;
        }

        public override string ToString()
        {
            return string.Format("{0}:{1}", name, price);
        }
    }

    public static class Extensions
    {
        public static void Print<T>(this List<T> list)
        {
            list.ForEach(i => Console.WriteLine(i.ToString()));

            Console.ReadKey();
        }
    }
}