using System;


namespace ExercicioPOO01 {
    class Retangulo {
        public double basee;
        public double altura;

        public double area() {

            return basee * altura;
        }
        public double perimetro() {
            return (2 * (basee + altura));
        }
        public double diagonal() {
            return (Math.Sqrt(Math.Pow(basee, 2) + (Math.Pow(altura, 2))));
        }

    }
}
