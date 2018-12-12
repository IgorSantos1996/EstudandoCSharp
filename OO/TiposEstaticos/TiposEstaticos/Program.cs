using System;
using System.Globalization;

namespace TiposEstaticos {
    class Program {
        /* Exemplo 01
         * static double PI = 3.14; // tem que ser estático pois estamos usando dentro de um método estático

        static void Main(string[] args) {
            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = circunferencia(raio);
            double volume = Volume(raio);
            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de pi " + PI.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
        static double circunferencia(double r) { // tenho que usar estático pq senão, não consigo chamar no main
            return 2 * PI * r;
        }
        static double Volume(double r) {
            return 4 / 3 * PI * Math.Pow(r, 3);
        }*/
        static void Main(string[] args) {
            Calculadora c = new Calculadora();
            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = c.circunferencia(raio);
            double volume = c.Volume(raio);
            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de pi " + c.PI.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();

        }
    }
}
