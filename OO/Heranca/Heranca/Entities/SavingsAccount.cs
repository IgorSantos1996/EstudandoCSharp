using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca.Entities
{
     class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {

        }
        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }
        public void updateBalance()
        {
            Balance = Balance * InterestRate;
        }
        public sealed override void Withdraw(double amount) // não posso sobrescrever esse método mais uma vez em uma subclasse
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }

    }
}
