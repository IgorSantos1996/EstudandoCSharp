using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace NullDelegates
{

    public delegate void PagarEvent(double valor);
    public class Pedido
    {

        public event PagarEvent Pagar;
        public void Fechar(double valor)
        {
            //delegaçao com delegate / event
            Pagar?.Invoke(valor);
            
        }
    }
}
