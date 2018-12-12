using System;
using System.Globalization;

namespace Construtores01 {
    internal class Program {
        public static void Main(string[] args) {
            /*//Produto p = new Produto("TV", 5000.0, 10);
            //Console.WriteLine(p);
            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome : ");
            string nome = Console.ReadLine();
            Console.Write("Preço : ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            
            Produto p2 = new Produto { Nome = "Tv", Preco = 500.00, Quantidade = 30 }; // outra formula de estar instanciando

            Console.WriteLine("Dados do produto: " + p2.ToString());
            Console.WriteLine(" \n");

            Console.WriteLine("Digite o numero de produtos a serem adicionados ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p2.AdicionarProdutos(qte);
            Console.WriteLine("Dados atualizados: " + p2.ToString());

            Console.WriteLine("Digite o numero de produtos a serem removidos ao estoque: ");
            qte = int.Parse(Console.ReadLine());
            p2.RemoverProduto(qte);
            Console.WriteLine("Dados atualizados: " + p2.ToString());

        */
            Produto p = new Produto("Tv 4k", 500, 10);
            p.Nome = "T";
            Console.WriteLine(p.Nome);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
