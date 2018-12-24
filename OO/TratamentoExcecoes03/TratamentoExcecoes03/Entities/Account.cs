using System;
using System.Collections.Generic;
using System.Text;
using TratamentoExcecoes03.Entities.Excecoes;

namespace TratamentoExcecoes03.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }


        public Account(int number, string holder, double balance, double withdraw)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdraw;
        }
        public void deposit(double amount)
        {

            Balance = Balance + amount;
        }
        public void withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainExcecoes("The amount exceeds withdraw limit");
            }
            if (amount > Balance)
            {
                throw new DomainExcecoes("Not enought balance");
            }
            Balance -= amount;
        }

    }
}
