using System;
using Composition.Entities.Enums;
using Composition.Entities;
using System.Globalization;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o nome do departamento: ");
            string dptname = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Level/MidLevel/Senior");
            WorkerLevel wl = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.WriteLine("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departament departament = new Departament(dptname);
            Worker worker = new Worker(name, wl, baseSalary, departament);
            Console.WriteLine("How many contracts to this worker?");

            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.WriteLine("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Duration (Hours):");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }
            Console.WriteLine();
            Console.WriteLine("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int y = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Departament: " + worker.Departament.Name);
            Console.WriteLine("Income for " + monthAndYear + ":" + worker.Income(y, month));

            Console.ReadKey();

        }
    }
}
