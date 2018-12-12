using System;
using System.Globalization;

namespace IniciandoOO {
    class Program {
        static void Main(string[] args) {
           

            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();
            Console.WriteLine("Entre com a medida do triangulo X");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("\n");
            Console.WriteLine("Entre com a medida do triangulo y");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double areax = x.Area();


            double areaY = y.Area();

            Console.WriteLine("Area de X = " + areax.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            if (areax > areaY) {
                Console.WriteLine("Maior area é do triangulo X");
            } else {
                Console.WriteLine("Maior area é do triangulo Y");
            } /*
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();
            Console.WriteLine("Informe o nome da primeira pessoa");
            p1.nome = Console.ReadLine();
            Console.WriteLine("Informe a idade da primeira pessoa:");
            p1.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o nome da segundo pessoa: ");
            p2.nome = Console.ReadLine();
            Console.WriteLine("Informe a idade da segundo pessoa: ");
            p2.idade = int.Parse(Console.ReadLine());
            if (p1.idade > p2.idade) {
                Console.WriteLine("Pessoa mais velha é " + p1.nome);
            } else {
                Console.WriteLine("Pessoa mais velha é: " + p2.nome);
            }
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Informe o nome do primeiro funcionario: ");
            f1.nome = Console.ReadLine();
            Console.WriteLine("Informe o salario do primeiro funcionario: ");
            f1.salario = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe o nome do segundo funcionario: ");
            f2.nome = Console.ReadLine();
            Console.WriteLine("Informe o salario do primeiro funcionario: ");
            f2.salario = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double media = (f1.salario + f2.salario) / 2.0;
            Console.WriteLine("Salario medio: " + media.ToString("F2", CultureInfo.InvariantCulture));
            */
            Console.ReadKey();
        }
    }
}
