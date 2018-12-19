using System;
using System.Collections.Generic;
using System.Globalization;
namespace ExerciciosPolimorfismo01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listaemployees = new List<Employee>();
            Console.WriteLine("Enter the number of employees: ");

            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($" Employee #{i} data: ");
                Console.Write("Outsourced (y/n)?");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valorhora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'y')
                {
                    Console.WriteLine("Additional Charge: ");
                    double additional = double.Parse(Console.ReadLine());
                    listaemployees.Add(new OutsourcedEmployee(nome, valorhora, hours, additional));
                }
                else
                {
                    listaemployees.Add(new Employee(nome, valorhora, hours));
                }
                Console.WriteLine();
                Console.WriteLine("PAYMENTS: ");
                foreach (Employee item in listaemployees)
                {
                    Console.WriteLine(item.Name + " - $ - " + item.payment().ToString("F2", CultureInfo.InvariantCulture));
                }
                Console.ReadKey();

            }
        }
    }
}
