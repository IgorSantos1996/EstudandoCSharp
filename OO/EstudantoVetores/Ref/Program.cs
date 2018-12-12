using System;

namespace Ref {
    class Program {
        static void Main(string[] args) {
            int a = 10;
            int triplo;
            Calculador.Triple(ref a); // se usar o ref tem que iniciar a variavel
            Calculador.Triple(
                a,
                out triplo); // se usar o out não precisa iniciar a variavel
            Console.WriteLine(a);
            Console.WriteLine(triplo);
            Console.ReadKey();
        }
    }
}
