using System;

namespace Course05 {
    class Program {
        static void Main(string[] args) {
            /*int senha = 2002;
            int tentativa = 0;
            while (senha != tentativa) {
                Console.WriteLine("Informe a senha: ");
                tentativa = int.Parse(Console.ReadLine());
                if (tentativa == senha) {
                    Console.WriteLine("Acesso permitido");
                    break;
                } else {
                    Console.WriteLine("Senha inválida");
                }
            }
            string[] vet = Console.ReadLine().Split(' ');
            int x = int.Parse(vet[0]);
            int y = int.Parse(vet[1]);
            while (x != 0 && y != 0) {
                if (x > 0 && y > 0) {
                    Console.WriteLine("Primeiro");
                } else if (x < 0 && y > 0) {
                    Console.WriteLine("Segundo");
                } else if (x < 0 && y < 0) {
                    Console.WriteLine("Terceiro");
                } else {
                    Console.WriteLine("Quarto");
                }
                vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]); 
            }
            */
            Console.WriteLine("1 - Alcool 2 - Gasolina 3 - Diesel 4 - Fim");
            int codigo = int.Parse(Console.ReadLine());
            int gasolina = 0;
            int diesel = 0;
            int alcool = 0;
            while (codigo != 4) {
                if (codigo == 1) {
                    alcool++;
                } else if (codigo == 2) {
                    gasolina++;
                } else if (codigo == 3) {
                    codigo++;
                }
                codigo = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Muito obrigado");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
            Console.ReadKey();
        }
    }
}
