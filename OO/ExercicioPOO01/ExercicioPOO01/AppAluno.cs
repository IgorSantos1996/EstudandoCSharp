using System;
using System.Globalization;

namespace ExercicioPOO01 {
    class AppAluno {
        public static void Main(string[] args) {
            Aluno a = new Aluno();
            Console.WriteLine("Informe o nome do aluno: ");
            a.nome = Console.ReadLine();
            Console.WriteLine("Informe a primeira nota do aluno: ");
            a.nota1 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe a segunda nota do aluno: ");
            a.nota2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe a terceira nota do aluno: ");
            a.nota3 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Nota final = " + a.notaFinal().ToString("F2", CultureInfo.InvariantCulture));
            if (a.aprovado()) {
                Console.WriteLine("Aprovado");
            } else {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltaram " + a.quantoFaltaAprovacao().ToString("F2", CultureInfo.InvariantCulture) + " pontos");
            }
        }
    }
}
