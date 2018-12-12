using System;

namespace Params {
    class Program {
        static void Main(string[] args) {
            //int s1 = Calculator.Sum(new int[] { 1, 2, 4, 4 });// não preciso instanciar assim
            int s1 = Calculator.Sum(2, 3);
            //int s2 = Calculator.Sum(new int[] { 1, 4, 6, 7 });
            int s2 = Calculator.Sum(3, 5);
            //isso foi possível graças ao modificar de parãmetros chamado param
            // la da classe Calculator, no método Sum();
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
