using System;
using System.Globalization;

namespace Vetores02 {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine()); // tamanho do meu vetor  
            Product[] product = new Product[n]; // instanciando um vetor de produtos de tamanho n
            for (int k = 0; k < n; k++) { // for pra iterar meu vetor
                string name = Console.ReadLine(); // ler o nome dos meus produtos
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // ler o preco dos meus produtos
                product[k] = new Product { Nome = name, Price = price }; // é como se em cada posição do meu vetor, precisasse instaciar um produto
            }
            double soma = 0.0; // guardar a soma dos valores que informei
            for (int i = 0; i < n; i++) {
                soma = soma + product[i].Price; // somar o preco dos meus produtos
            }
            double avg = soma / n; // calcula a média
            Console.WriteLine("Average Price = " + avg.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
