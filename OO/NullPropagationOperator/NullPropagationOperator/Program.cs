using System;
using static System.Console;
namespace NullPropagationOperator
{
    public class Aluno
    {
        public int Matricula { get; set; } = 0;
        public string Nome { get; set; } = "Sem nome";
        public Curso Curso { get; set; }
    }
    public class Area
    {
        public string NomeArea { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var gp = new Aluno
            {
                Matricula = 123,
                Nome = "Guinter",
                Curso = new Curso() { NomeCurso = "Sistemas de informação" , Area = new Area() { NomeArea = "Ciências Exatas"} }
            };
            WriteLine($"\nMatricula: {gp.Matricula} \nNome: {gp.Nome}");
            WriteLine($"Curso: {gp?.Curso?.NomeCurso ?? "Sem curso"}"); // testando se está instanciado null reference 
            WriteLine($"AreadoCurso: {gp?.Curso?.Area?.NomeArea ?? "Sem Área"}");

            /*if (gp.Curso != null)
            {
                WriteLine($"Curso: {gp.Curso.NomeCurso}");
                if (gp.Curso.area != null)
                {
                    WriteLine($"Area : {gp.Curso.area.NomeArea}");
                }
            }
            else
            {
                WriteLine("Aluno não tem curso");
            }
            */
            ReadKey();
        }
    }
}
