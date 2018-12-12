using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioMembrosEstaticos {
    class ConversorMoedas {
        public static double iof = 6.0;
        public static double converter(double quantia, double cotacao) {
            double total = quantia * cotacao;
            return total = total * iof / 100.0;

        }
    }
}
