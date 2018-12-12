using System;
using System.Collections;
using System.Collections.Generic;

namespace Generics02 {
    class Program {
        static void Main(string[] args) {

            ArrayList al = new ArrayList();
            
            al.Add(10);
            List<int> lista = new List<int>();
            lista.Add(2);
            lista.Add(4);
            foreach (object item in lista) {
                Console.WriteLine("Livro Código: " + item.ToString());
            }

            
            Console.ReadKey();
        }
    }
}
