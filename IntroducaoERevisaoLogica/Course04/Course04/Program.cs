using System;
using System.Globalization;

namespace Course04 {
    class Program {
        static void Main(string[] args) {
            /*float altura;
            int idade;
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa: ");
            sbyte qt = sbyte.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço do produto:  ");
            float preco = float.Parse(Console.ReadLine());
            Console.WriteLine("Entre com seu ultimo nome, idade e altura: ");
            string[] vet = Console.ReadLine().Split(' ');
            string p1 = vet[0];
            idade = int.Parse(vet[1]);
            altura = float.Parse(vet[2], CultureInfo.InvariantCulture);
            Console.WriteLine(p1 + " " + idade + " " + altura);
            Console.WriteLine("Entre com um número inteiro: ");
            int x = int.Parse(Console.ReadLine());
            if (x % 2 == 0) {
                Console.WriteLine("Par");
            } else {
                Console.WriteLine("Impar");
            }
            Console.WriteLine("Digite três números:");
            int maior;
            string[] mx = Console.ReadLine().Split(' ');
            int p0 = int.Parse(mx[0]);
            int p1 = int.Parse(mx[1]);
            int p2 = int.Parse(mx[2]);
            if (p0 > p1 && p0 > p2) {
                maior = p0;
            } else if (p1 > p2) {
                maior = p1;
            } else {
                maior = p2;
            }
            Console.WriteLine("O maior numero é: " + maior );
            Console.WriteLine("Digite um numero: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (x >= 0.0) {
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("Digite outro numero: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Numero negativo!");
            Console.WriteLine("Informe a qtd de numeros que quer ler: ");
            int k = int.Parse(Console.ReadLine());
            int soma = 0;
            for (int r = 1; r <= k; r++) {
                Console.WriteLine("Valor #{0}: ", r);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
            Console.WriteLine("Soma = " + soma);
            Console.WriteLine("Informe o valor de a:");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de b : ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe  o valor de c: ");
            float c = float.Parse(Console.ReadLine());
            float area = (a * c) / 2;

            Console.WriteLine(area.ToString("F2"));
            Console.WriteLine("Informe o valor do raio: ");
            float raio = float.Parse(Console.ReadLine());
            double area1 = (3.14159) * (raio * raio);
            Console.WriteLine("A area do circulo é :" + area1.ToString("F2"));
            area1 = (((a * b) / 2) * c);
            Console.WriteLine("A área do trapézio é: " + area1);
            Console.WriteLine("A area do quadrado é: " + Math.Pow(b, 2));
            Console.WriteLine("A area do retangulo é: " + (a * b));
            if (a % b == 0 || b % a == 0) {
                Console.WriteLine("São multiplos!!");
            } else {
                Console.WriteLine("Não são multiplos");
            }
            Console.WriteLine("Informa a hora inicial e final do jogo: ");
            string[] vet = Console.ReadLine().Split(' ');
            int horainicial = int.Parse(vet[0]);
            int horafinal = int.Parse(vet[1]);
            int duracao;
            if (horainicial < horafinal) {
                duracao = horafinal - horainicial;
            } else {
                duracao = 24 - horainicial + horafinal;
            }
            Console.WriteLine("O jogo durou " + duracao + " Horas(S)");*/
            Console.WriteLine("Informe o valor do salario: ");
            double imposto;
            double valor = double.Parse(Console.ReadLine());
            if (valor >= 0.00 && valor <= 2000.0) {
                imposto = 0.0;
            } else if (valor <= 30000.00) {
                imposto = (valor - 2000.0) * 0.8;

            } else if (valor <= 4500.0) {
                imposto = (valor - 3000.0) * 0.18 + 1000.0 * 0.08;
            } else {
                imposto = (valor - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;

            }
            if (imposto == 0.0) {
                Console.WriteLine("Isento");
            } else {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.ReadKey();
        }
    }
}
