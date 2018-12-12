using System;
using System.Globalization;

namespace Course06 {
    class Program {
        static void Main(string[] args) {
            /* Exemplo 1 
             * Console.WriteLine("Informe o valor de x: ");
            int x = int.Parse(Console.ReadLine());
            for (int l = 0; l <= x; l++) {
                if( l % 3 == 0) {
                    Console.WriteLine("Valor {0}", l);
                }
            }
            //Segundo exemplo
            Console.WriteLine("Informe o valor da variavel n: ");
            int n = int.Parse(Console.ReadLine());

            for (int p = 0; p < n; p++) {
                string[] line = Console.ReadLine().Split(' ');
                double a = double.Parse(line[0], CultureInfo.InvariantCulture);
                double b = double.Parse(line[1], CultureInfo.InvariantCulture);
                double c = double.Parse(line[2], CultureInfo.InvariantCulture);

                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            } // terceiro exemplo
            Console.WriteLine("Informe o valor da variável x: ");
            int n = int.Parse(Console.ReadLine());
            for (int f = 0; f < n; f++) {
                string[] numeros = Console.ReadLine().Split(' ');
                int x = int.Parse(numeros[0]);
                int y = int.Parse(numeros[1]);

                if (y == 0)
                    Console.WriteLine("Divisão impossível");
                else {
                    double div = (double)x / y;
                    Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture));
                }

            }
            */
            Console.WriteLine("Informe o valor de n: ");
            int n = int.Parse(Console.ReadLine());

            int fat = 1;
            for (int p = 1; p <= n; p++) {
                fat *= p;
            }
            Console.WriteLine(fat);
            Console.ReadKey();
        }
    }
}
