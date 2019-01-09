using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1.Service;
using Service;

namespace ConsoleApp1.Service
{
    class PaypalService : OnlinePaymentService
    {
        private const double FeePercentage = 0.02;
        private const double MonthlyInterest = 0.01;

        public double Interest(double amount, int months)
        {
            return amount * MonthlyInterest * months;
        }

        public double PaymentFee(double amount)
        {
            return amount * FeePercentage;
        }
    }
}
