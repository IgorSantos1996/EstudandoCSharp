using System;
using System.Globalization;


namespace ExemploSwitch {
    class Program {
        static void Main(string[] args) {
            int k = int.Parse(Console.ReadLine());
            string day;
            double preco = 1.3, desconto = 0;

            double desconto01 = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

            //ou...
            if (preco < 20.0) {
                desconto = desconto * 0.1;
            } else {
                desconto = desconto * 0.05;
            }
            Console.WriteLine(desconto);

            switch (k) {
                case 1:
                    day = "Sunday";
                    break;
                case 2:
                    day = "Monday";
                    break;
                case 3:
                    day = "Tuesday";
                    break;
                case 4:
                    day = "Wenesday";
                    break;
                case 5:
                    day = "Thursday";
                    break;
                case 6:
                    day = "Friday";
                    break;
                case 7:
                    day = "Saturday";
                    break;
                default:
                    day = "Invalid value";
                    break;
            }
            Console.WriteLine("Day : " + day);
            Console.ReadKey();

        }
    }
}
