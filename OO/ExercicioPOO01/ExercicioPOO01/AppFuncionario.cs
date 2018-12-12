/*using System;
using System.Globalization;

namespace ExercicioPOO01 {
    class AppFuncionario {
        public static void Main(string[] args) {
            Funcionario f = new Funcionario();
            Console.WriteLine("Informe o nome do funcionario: ");
            f.nome = Console.ReadLine();

            Console.WriteLine("Informe o salário bruto do funcionario: ");
            f.salarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe o desconto do funcionario: ");
            f.desconto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Dados do funcionario" + f.ToString());
            Console.WriteLine();

            Console.WriteLine("Deseja aumentar o salário em qual porcentagem: ");
            int porcent = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            f.aumentarSalario(porcent);
            Console.WriteLine();
            Console.WriteLine("Dados do funcionario " + f.ToString());
            Console.ReadKey();



        }
    }
}
*/