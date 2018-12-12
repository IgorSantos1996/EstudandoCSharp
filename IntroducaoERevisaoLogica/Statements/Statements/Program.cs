using System;

namespace Statements {
    class Program {
        static void Main(string[] args) {
            int a = 3;
            #region switch
            if (a == 5) {
                Console.WriteLine("a = 5");
            } else if (a == 10) {
                Console.WriteLine("a == 10");
            } else if (a == 8) {
                Console.WriteLine("a == 8");
            } else {
                Console.WriteLine("a == " + a.ToString());
            }
            

            #endregion
            int c = 0;
            switch (c) {
                case 0:
                    Console.WriteLine("a == 0");
                    break;
                case 5:
                    Console.WriteLine("a == 5");
                    break;
                case 10:
                    Console.WriteLine("a == 10");
                    break;
                default:
                    Console.WriteLine("a == " + c.ToString());
                    break;

            }
            Console.ReadKey();
        }
    }
}
