using System;

namespace TratamentoExcecao01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                int result = n1 / n2;
                Console.WriteLine(result);
                Console.ReadLine();
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Error " + e.Message);
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Format error" + ex.Message);
                Console.ReadLine();
            }
        }
    }
}
