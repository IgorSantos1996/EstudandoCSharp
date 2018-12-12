using System;
using System.Globalization;


namespace Exemplo02OO {
    public class App {
        public static void Main(string[] args) {
            Produto p = new Produto();
            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome : ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço : ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + p.ToString());
            Console.WriteLine(" \n");

            Console.WriteLine("Digite o numero de produtos a serem adicionados ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine("Dados atualizados: " + p.ToString());

            Console.WriteLine("Digite o numero de produtos a serem removidos ao estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProduto(qte);
            Console.WriteLine("Dados atualizados: " + p.ToString());


            Console.ReadKey();
        }
    }
}
