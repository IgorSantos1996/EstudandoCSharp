using System;
using ClassesAbstratas.Entities;
using System.Collections.Generic;
using System.Globalization;


namespace ClassesAbstratas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
            */
            List<Account> list = new List<Account>();
            list.Add(new SavingsAccount(1001, "Maria", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400));
            list.Add(new SavingsAccount(1003, "Bob", 500.0, 100));
            double soma = 0;
            foreach (Account item in list)
            {
                soma = soma + item.Balance;
            }
            Console.WriteLine("Total balance : " + soma.ToString("F2", CultureInfo.InvariantCulture));
            foreach (Account item in list)
            {
                item.Withdraw(10.0);
            }
            foreach (Account item in list)
            {
                Console.WriteLine("Updated balance for account "
                    + item.Balance
                    + " : " +
                     item.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.ReadKey();
        }
    }
}