using System;
using ExercicioPolimorfismo.Entities;
using System.Collections.Generic;
using System.Globalization;
namespace ExercicioPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> lista = new List<Product>();

            Console.WriteLine("Entre the number of products: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Product #" + i + " data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                String name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (type == 'c')
                {
                    lista.Add(new Product(name, price));
                }
                else if (type == 'u')
                {
                    Console.WriteLine("Manufacture date (DD/MM/YYYY");
                    DateTime time = DateTime.Parse(Console.ReadLine());
                    lista.Add(new UsedProduct(name, price, time));

                }
                else
                {
                    Console.WriteLine("Customs fee:");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new ImportedProduct(name, price, customsFee));
                }
                Console.WriteLine();
                Console.WriteLine("Price tags: ");
                foreach (Product item in lista)
                {
                    Console.WriteLine(item.priceTag());
                }
                Console.ReadKey();
            }
        }
    }
}
