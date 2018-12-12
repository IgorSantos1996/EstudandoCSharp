using System;
using System.Globalization; // para utilizar ponto ao inves de virgula ao exibir

namespace Course02 {
    class Program {
        static void Main(string[] args) {
            char genero = 'F';
            int idade = 32;
            double saldo = 10.2124441;
            string nome = "maria";
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo); // exemplo de placeholders e duas casas
            Console.WriteLine("Boa tarde");
            Console.WriteLine("Bom dia");
            Console.WriteLine("Boa noite");
            Console.WriteLine(genero + " " + idade + " " + saldo + " " + nome);
            Console.WriteLine(saldo.ToString("F2")); // F2 para delimitar o numero de casas da variavel saldo
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture)); // imprimir com ponto ao inves de virgula com pontos flutuantes
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais"); // usando interpolação
            Console.WriteLine(nome + " tem " + idade + " e tem saldo igual a " + saldo.ToString("F2").ToString(CultureInfo.InvariantCulture) + " reais");

            Console.ReadKey();
        }
    }
}
