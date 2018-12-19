using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosPolimorfismo01
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee(string name, double valuePerHour, double perhour, double addi) : base(name, valuePerHour, perhour)
        {
            AdditionalCharge = addi;
        }
        public override double payment()
        {
            return base.payment() + 1.1 * AdditionalCharge;
        }
    }
}
