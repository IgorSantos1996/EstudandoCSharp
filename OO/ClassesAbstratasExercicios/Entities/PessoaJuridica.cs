using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAbstratasExercicios.Entities
{
    class PessoaJuridica : Contribuinte
    {
        public int NumberOfEmployees { get; set; }

        public PessoaJuridica(string nome, double anual, int numberOfEmployees) : base(nome, anual)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double tax()
        {
            if (NumberOfEmployees > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}
