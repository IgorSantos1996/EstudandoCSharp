using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    interface OnlinePaymentService
    {
        double PaymentFee(double amount);
        double Interest(double amount, int months);
    }
}
