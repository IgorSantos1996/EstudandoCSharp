using System;
using System.Globalization;

namespace ExercicioMembrosEstaticos {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre com a cotação do dólar: ");
            float cotacao = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            float dolares = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double result = ConversorMoedas.converter(dolares, cotacao);
            Console.WriteLine("Valor a ser pago em reais: " + result.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
