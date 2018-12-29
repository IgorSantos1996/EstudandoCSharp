using System;

namespace ExpressionsBodies02
{
    public static class Calculadora
    {
        public static string Nome { get; set; } = "C#  Calc";
        public static int Soma(int x, int y) => x + y;
        public static int Multiplicar(int x, int y) => x * y;
        //{
        //  return x + y;
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            int x = 9, y = 3;
            var r1
                = Calculadora.Soma(x, y);
            Console.WriteLine($"Usando a calculadora {Calculadora.Nome}" +
                $" Soma : {r1}");
            var r2 = Calculadora.Multiplicar(x, y);
            Console.WriteLine($"Usando {Calculadora.Nome} , " +
                $"Multiplicação de {x} e {y} é {r2} ");
            Console.ReadKey();
        }
    }
}
