using System;

namespace AnonymousType {
    class Program {
        static void Main(string[] args) {
            Nullable<int> i = null;
            //LINQ
            var valores = new[] { new { idade = 18, nome = "Luiz" }, new { idade = 20, nome = "alberto" } };
            foreach (var item in valores) {
                Console.WriteLine("Idade: " + item.idade.ToString());
                Console.WriteLine("Nome: " + item.nome.ToString());
            }
            Console.ReadKey();
        }
    }
}
