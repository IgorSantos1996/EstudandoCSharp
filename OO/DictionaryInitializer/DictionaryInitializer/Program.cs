using System;
using System.Collections.Generic;

namespace DictionaryInitializer
{
    public class Aluno
    {

        public string Nome { get; set; }

        //public Aluno(string nome)
        //{
        //    Nome = nome;
        //}
    }

    class Program
    {
        static void Main(string[] args)
        {
            var Alunos = new Dictionary<int, Aluno>()
            {
                [123] = new Aluno() { Nome = "Guinter" }
            };
            Console.WriteLine("Informe a chave ");
            var index = int.Parse(Console.ReadLine());
            Console.WriteLine($"Alunos : {Alunos[index].Nome }");


            //var a1 = new Aluno() { Nome = "Guinter" };
            //var a2 = new Aluno() { Nome = "Carlos" };
            //var Alunos = new Dictionary<int, Aluno>()
            //{
            //    {88 ,a1 },
            //    {12, a2 }

            //};
            //Console.WriteLine(Alunos[12].Nome);
            Console.ReadKey();
            //var Alunos = new Dictionary<int, Aluno>();
            //Alunos.Add(1, new Aluno() { Nome = "José" });
            //Alunos.Add(2, new Aluno() { Nome = "Felipe"});
            //Alunos.Add(3, new Aluno() { Nome = "Ester" });


            // var Alunos = new List<Aluno>()
            // {
            //new Aluno () { Nome = "Igor"},
            //new Aluno() { Nome = "Guta"}
            // };

            //var Alunos = new List<Aluno>();
            //Alunos.Add(new Aluno() { Nome = "Igor" });
            //Aluno a1 = new Aluno() { Nome = "Igor" };
            //a1.Nome = "Igor";
        }
    }
}

