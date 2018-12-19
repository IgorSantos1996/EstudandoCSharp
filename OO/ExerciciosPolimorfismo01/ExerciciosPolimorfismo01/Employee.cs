using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosPolimorfismo01
{
    class Employee
    {
        public string Name { get; set; }
        public double ValuePerHour { get; set; }
        public double PerHour { get; set; }

        public Employee(string name, double valuePerHour, double perhour)
        {
            Name = name;
            ValuePerHour = valuePerHour;
            PerHour = perhour;
        }
        public virtual double payment()
        {
            return PerHour * ValuePerHour;
        }
    }
}
