using System;
using Heranca.Entities;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        { /* ==================== PRIMEIRA PARTE =================== 
            //BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);
            //Console.WriteLine(account.Balance);

            // account.Balance = 200.0; isso aqui da erro pq Balance esta como protected
            // portanto apenas a propria classe e subclasses podem alterar
            Account acc = new Account(1101, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //UPCASTING superclasse <-- subclase, subclase -->> superclasse, 
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            //DOWNCASTING superclasse ->> subclasse, subclasse <<- superclasse
            // tem que testar pra ver se a variável é do tipo da que eu quero
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);
            //acc2.Loan(100.0);  ERRO:  acc2 é do tipo account. Compilador não sabe acc2 é um tipo businessAccount
            //BusinessAccount acc5 = (BusinessAccount)acc3;  isso aqui vai dar erro, quando executar. Pois, acc é SavingsAccount, e estamos tentando realizar um downcasting para BusinessesAccount
            if (acc3 is BusinessAccount) // testar se acc3 é do tipo BusinessAccount. Vai dar False aqui
            {
                BusinessAccount acc5 = (BusinessAccount)acc3;
                //Sintaxe alternartiva : BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200);
                Console.WriteLine("Loan");
            }

            if(acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                //Sintaxe alternartiva SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.updateBalance();
                Console.WriteLine("Update");
            }
            Console.ReadKey();

            */
            Account acc1 = new Account(1001, "alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Ana", 500, 0.01);
            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);

            Console.ReadLine();

        }
    }
}
