using System;
using static System.Console;

namespace ExcpetionFilters
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 99999999;
            var y = 0;
            int R1 = 0;
            int R2 = 0;
            try
            {
                R1 = x / y;
                WriteLine($"{x} dividido por {y} é igual a {R1}");
                R2 = checked(x * y);
                WriteLine($"{x} multiplicado por {y} é igual a {R2}");

            }
            //catch(OverflowException ex)
            //{
            //    WriteLine($"{ex.Message}");
            //}
            //catch (DivideByZeroException e)
            //{
            //    WriteLine($"{e.Message}");
            //}
            catch (Exception ex) when (ex.Message.ToUpper().Contains("ESTOURO"))
            {//filtrando a exceção - > "Quando" ex.Message contém a palavra "ESTOURO". show...
                WriteLine($"Mensagem:  { ex.Message}");
                ReadKey();
            }
            catch (Exception e) when (e.Message.ToUpper().Contains("ZERO"))
            {
                WriteLine($"Mensagem:  { e.Message}");
                ReadKey();
            }
        }
    }
}
