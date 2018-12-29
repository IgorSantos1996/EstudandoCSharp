using System;
using static System.Console;

namespace ExpressionsBodies
{
    public delegate void PagarEvent(double valor);
    public class Pedido
    {
        public event PagarEvent Pagar;
        public void FecharPedido(double valor)
        {
            Pagar(valor);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var pedido = new Pedido();
            pedido.Pagar += v => WriteLine($"Pago valor de {v}");
            pedido.FecharPedido(2000);
        }

        //private static void Pedido_Pagar(double valor)
        //{
        //  WriteLine($"Pago valor de {valor} ");
        //}
    }
}
