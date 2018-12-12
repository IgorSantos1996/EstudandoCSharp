using System;

namespace Course {
    class Program {
        static void Main(string[] args) {

            bool completo = false;
            byte n1 = 126;
            char genero = 's';
            char letra = '\u0041';
            n1++;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147484648L;
            float n5 = 4.5F;
            string nome = "Maria";
            object obj = 4.5f;
            int min = int.MinValue;
            int max = int.MaxValue;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(false);
            Console.WriteLine(letra);
            Console.WriteLine(genero);
            Console.WriteLine(obj);
            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.ReadKey();
            
            // digitar cw e apertar tab tab -> atalho
        }
    }
}
