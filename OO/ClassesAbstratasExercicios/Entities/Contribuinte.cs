using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAbstratasExercicios.Entities
{
    abstract class Contribuinte
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public Contribuinte(string nome, double anual)
        {
            Name = nome;
            AnualIncome = anual;
        }
        public abstract double tax();
        
    }
}
