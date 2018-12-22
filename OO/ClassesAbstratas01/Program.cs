using System;
using ClassesAbstratas01.Entities.Enums;
using ClassesAbstratas01.Entities;
using System.Globalization;
using System.Collections.Generic;

namespace ClassesAbstratas01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> lista = new List<Shape>();
            Console.WriteLine("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Rectangle or Circle(r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red)");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (ch == 'r')
                {
                    Console.Write("Digite a largura: ");
                    double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Digite a altura: ");
                    double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new Rectangle(largura, altura, color));

                }
                else
                {
                    Console.Write("Entre com o raio: ");
                    double radio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new Circle(radio, color));

                }


            }
            Console.WriteLine();
            Console.WriteLine("Shape Areas: ");
            foreach (Shape item in lista)
            {
                Console.WriteLine(item.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.ReadKey();
        }
    }
}
