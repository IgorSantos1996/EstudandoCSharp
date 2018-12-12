using System;

namespace Timee {
    class Program {
        static void Main(string[] args) {
            /*TimeSpan t1 = new TimeSpan(0, 1, 30);
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);
            TimeSpan t2 = new TimeSpan(90000000l);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 321);
            Console.WriteLine("=================");
            Console.WriteLine(t2);
            */
            TimeSpan t1 = TimeSpan.FromDays(1.5);
            TimeSpan t2 = TimeSpan.FromHours(1.5);
            TimeSpan t3 = TimeSpan.FromMinutes(1.5);
            TimeSpan t4 = TimeSpan.FromSeconds(1.5);
            TimeSpan t5 = TimeSpan.Zero;
            TimeSpan t6 = TimeSpan.MaxValue;
            TimeSpan t7 = TimeSpan.MinValue;
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);
            Console.WriteLine(t7);
            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
            Console.WriteLine("Days: " + t.Days);
            TimeSpan ts = new TimeSpan(1, 30, 10);
            TimeSpan ts2 = new TimeSpan(0, 10, 5);

            TimeSpan sum = ts.Add(ts2); // somar os timespan
            TimeSpan dif = ts.Subtract(ts2); // subtrair ts2
            TimeSpan mult = ts.Multiply(2.0);
            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
