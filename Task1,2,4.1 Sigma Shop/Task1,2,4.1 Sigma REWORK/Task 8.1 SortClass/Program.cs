using System;
using System.Collections.Generic;

namespace Task_8._1_Sort
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> productsList = new List<Product>(100);
            Product[] products = new Product[100];
            int size;
            SortClass sortClass = new SortClass();


            Console.WriteLine("Enter size: ");
            size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();




            Console.WriteLine("Input name, price and weight:");
            for (int i = 0; i < size; i++)
            {
                productsList.Add(new Product()
                {
                    Name = Console.ReadLine(),
                    Price = Convert.ToInt32(Console.ReadLine()),
                    Weight = Convert.ToInt32(Console.ReadLine())
                });

            }

            products = productsList.ToArray();

            Console.WriteLine("Starting Array: ");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Name: {products[i].Name}");
                Console.WriteLine($"Price: {products[i].Price}");
                Console.WriteLine($"Weight: { products[i].Weight}");
                Console.WriteLine();

            }
            Console.WriteLine();


            SortClass.Sort(products, size,SortClass.PriceComparcion);
            
            Console.WriteLine("Sorted by Price Array: ");

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Name: {products[i].Name}");
                Console.WriteLine($"Price: {products[i].Price}");
                Console.WriteLine($"Weight: { products[i].Weight}");
                Console.WriteLine();

            }
            Console.WriteLine();

            SortClass.Sort(products, size, SortClass.WeightComparcion);
            Console.WriteLine("Sorted by Weight Array: ");

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Name: {products[i].Name}");
                Console.WriteLine($"Price: {products[i].Price}");
                Console.WriteLine($"Weight: { products[i].Weight}");
                Console.WriteLine();

            }
            Console.WriteLine();




        }


    }


    
}

