using System;
using System.Globalization;

namespace TiposEstaticos {
    class Calculadora {
        public double PI = 3.14;

        public double circunferencia(double r) { // tenho que usar estático pq senão, não consigo chamar no main
            return 2 * PI * r;
        }
        public double Volume(double r) {
            return 4 / 3 * PI * Math.Pow(r, 3);
        }
    }
}
