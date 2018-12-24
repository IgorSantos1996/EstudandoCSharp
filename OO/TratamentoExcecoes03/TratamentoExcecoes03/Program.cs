using System;
using TratamentoExcecoes03.Entities;
using TratamentoExcecoes03.Entities.Excecoes;
using System.Globalization;

namespace TratamentoExcecoes03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account data: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Holder: ");
            string holder = Console.ReadLine();
            Console.WriteLine("Initial Balance: ");
            double inicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Withdraw limit: ");
            double withdrawlimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Account acc = new Account(number, holder, inicial, withdrawlimit);
            Console.WriteLine();

            Console.Write("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            try
            {
                acc.withdraw(amount);
                Console.WriteLine("New balance :" + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (DomainExcecoes e)
            {
                Console.WriteLine("withdraw error :" + e.Message);
            }

        }
    }
}
