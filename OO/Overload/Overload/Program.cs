using System;

namespace Overload
{
    public class AlunoEspecial : Aluno
    {
        public string Situação { get; set; } = "Especial";
        public override string ToString()
        {
            return $"Matricula: {Matricula}- Nome: {Nome}- Situação: {Situação}";
        }
    }
    public class Aluno
    {
        public int Matricula { get; set; } = 0;
        public string Nome { get; set; } = "Igor";
        public override string ToString()
        {
            return $"Matrícula:{Matricula} - Nome {Nome}";
        }
    }

    class Program
    {
        static void Mostrar(string obj)
        {
            Console.WriteLine($"Mostrar (string) :{obj}");
        }
        static void Mostrar(int obj)
        {
            Console.WriteLine($"Mostrar (int) {obj}");
        }
        static void Mostrar(bool obj)
        {
            Console.WriteLine($"Mostrar (bool):{obj}");
        }
        static void Mostrar(object obj)
        {
            Console.WriteLine($"Mostrar (object) : {obj}");
        }
        static void Mostrar(Aluno obj)
        {
            Console.WriteLine($"Mostrar (Aluno) : {obj}");
        }
        static void Mostrar(AlunoEspecial obj)
        {
            Console.WriteLine($"Mostrar (AlunoEspecial) : {obj}");
        }
        static void Main(string[] args)
        {
            Mostrar("Ola mundo");
            Mostrar(10);
            Mostrar(false);
            Mostrar(new Aluno());
            Mostrar(new Aluno() { Matricula = 123, Nome = "Raul" });
            Console.ReadKey();
        }
    }
}
