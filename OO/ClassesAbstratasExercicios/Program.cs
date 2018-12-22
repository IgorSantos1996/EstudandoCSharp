using System;
using System.Collections.Generic;
using ClassesAbstratasExercicios.Entities;
using System.Globalization;

namespace ClassesAbstratasExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contribuinte> lista = new List<Contribuinte>();
            Console.WriteLine("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Tax payers #{i}");
                Console.Write("Individual or company (c/i) ?");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name :");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualincome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'i')
                {
                    Console.WriteLine("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine());
                    lista.Add(new PessoaFisica(name, anualincome, health));
                }
                else
                {
                    Console.WriteLine("Number of employees:");
                    int numberemployyes = int.Parse(Console.ReadLine());
                    lista.Add(new PessoaJuridica(name, anualincome, numberemployyes));
                }
            }
            double soma = 0;
            Console.WriteLine();
            Console.WriteLine("Taxes PAID: ");
            foreach (Contribuinte item in lista)
            {
                double tax = item.tax();
                Console.WriteLine(item.Name + " :  $ " + tax.ToString("F2", CultureInfo.InvariantCulture));
                soma += tax;

            }
            Console.WriteLine();
            Console.WriteLine("Total taxes : $ " + soma.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
