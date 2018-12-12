using System;

namespace Vetores03 {
    class Program {
        static void Main(string[] args) {
            Hospede[] hospedes = new Hospede[10];
            Console.WriteLine("Informe a quantidade de estudantes que podem ocupar os quartos: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++) {
                Console.WriteLine("Aluguel {0}: ", i);
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Email: ");
                string email = Console.ReadLine();
                Console.WriteLine("Quarto : ");
                int numberquarto = int.Parse(Console.ReadLine());
                hospedes[numberquarto] = new Hospede { Email = email, Nome = nome };
            }
            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++) {
                if (hospedes[i] != null) {
                    Console.WriteLine(i + ":  " + hospedes[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
