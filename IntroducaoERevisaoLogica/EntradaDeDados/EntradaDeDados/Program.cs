using System;
using System.Globalization;

namespace EntradaDeDados {
    class Program {
        static void Main(string[] args) {
            //string frase = Console.ReadLine();
            // Console.WriteLine("\n" + frase);
            //string s = Console.ReadLine();
            // int n1;
            // char ch;

            // string[] vet = Console.ReadLine().Split(' '); // esse jeito é melhor
            // string a = vet[0];
            // string b = vet[1];
            //string c = vet[2];

            //n1 = int.Parse(Console.ReadLine());
            // ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            // Console.WriteLine(n1);
            // Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
