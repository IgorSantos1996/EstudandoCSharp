using System;
using System.Globalization;

namespace ResolucaoExercicioEncapsulamento {
    class Program {
        static void Main(string[] args) {
            ContaBancaria cb;
            Console.Write("Entre com o número da conta");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o titular da conta: ");
            string tit = Console.ReadLine();

            Console.WriteLine("Haverá deposito inicial (s/n)?");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S') {
                Console.WriteLine("Digite o valor do deposito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                cb = new ContaBancaria(numero, tit, depositoInicial);
            } else {
                cb = new ContaBancaria(numero, tit);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(cb.ToString());
            Console.WriteLine();

            Console.WriteLine("Entre com o valor do deposito: ");
            double dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cb.Deposito(dep);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(cb.ToString());

            Console.WriteLine("Entre com o valor do saque: ");
            dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cb.Saque(dep);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(cb.ToString());


            Console.ReadKey();


        }
    }
}
