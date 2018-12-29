using System;
using static System.Convert;
namespace NullDelegates
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor do pedido: ");
            var valor = ToDouble(Console.ReadLine());
            var pedido = new Pedido();
            pedido.Pagar += v => Console.WriteLine($"pago valor de {valor} no valor "); 
            pedido.Fechar(valor);
            Console.ReadKey();
        }

        private static void Pedido_Pagar(double valor)
        {
            Console.WriteLine($"pago valor de {valor} no valor ");
        }
    }
}
