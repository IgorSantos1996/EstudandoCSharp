using System;
using static System.Console;

namespace NameOfOperator
{

    public class Professor
    {
        public string Matricula { get; set; } = "0";
        public string Nome { get; set; } = "sem nome";
        public DateTime date { get; set; } = DateTime.Now;
        public override string ToString()
        {
            return $"MAtricula: {Matricula}, Nome {Nome}, Data {date}";
        }
    }
    public static class Relatorio
    {
        public static void Imprimir(Professor professor)
        {
            WriteLine("Relatorio: ");
            WriteLine(professor?.ToString() ?? 
                $" o parâmetro de nome {nameof(professor)} não pode ser nulo");

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Professor it = null;
            WriteLine(it?.ToString() ?? $"Objeto {nameof(it)} não instanciado");
            it = new Professor() { Nome = "Igor", Matricula = "123" };
            WriteLine(it);
            Relatorio.Imprimir(it);

            ReadKey();
        }
    }
}
