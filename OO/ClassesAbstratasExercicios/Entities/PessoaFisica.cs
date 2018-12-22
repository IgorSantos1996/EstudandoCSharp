using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAbstratasExercicios.Entities
{
    class PessoaFisica : Contribuinte
    {
        public double HealthExpenditures { get; set; }

        public PessoaFisica(string nome, double anual, double health) : base(nome, anual)
        {
            HealthExpenditures = health;
        }
        public override double tax()
        {

            if (AnualIncome < 20000.00)
            {
                return AnualIncome * 0.15 - HealthExpenditures * 0.5;
            }

            else
            {
                return AnualIncome * 0.25 - HealthExpenditures * 0.5;
            }

        }
    }
}
