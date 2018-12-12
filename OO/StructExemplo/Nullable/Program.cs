using System;

namespace Nullable {
    class Program {
        static void Main(string[] args) {
            Nullable<double> x = null; // declarar uma variavel primitiva como nula
            //ou
            double? y = 10.0; // assim serve tbm
            Console.WriteLine(x.GetValueOrDefault()); // pegar o valor default da variavel se nao tiver valor
            Console.WriteLine(y.GetValueOrDefault());
            Console.WriteLine(x.HasValue); // ver se x tem valor
            Console.WriteLine(y.HasValue);
            //Console.WriteLine(x.Value); // gera uma exceção se tentar chamar ela a partir de de um objeto que é nullable
            Console.WriteLine(y.Value); // ver o valor de y
            if (x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("X is null");
            if (y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("Y is null");
            // operador de coalescencia
            Nullable<int> o = null;
            Nullable<int> k = 10;
            double a = o ?? 5; // eu jogo em -a o valor de -o, mas se o -o for nulo eu jogo 5
            double b = k ?? 6; // eu vou jogar em -b o valor de d, mas se -d for nul eu jogo 6
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
