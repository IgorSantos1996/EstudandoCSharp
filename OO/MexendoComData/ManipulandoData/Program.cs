using System;
using System.Globalization;

namespace ManipulandoData {
    class Program {
        static void Main(string[] args) {
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1.ToString());
            DateTime d2 = new DateTime(2018, 11, 25);
            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 1);
            DateTime d4 = new DateTime(2018, 11, 25, 20, 45, 1, 33);
            DateTime d8 = DateTime.Now;
            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.UtcNow;
            DateTime d7 = DateTime.Parse("2000-08-15 13:06:44");
            DateTime d9 = DateTime.Parse("14/12/2011 12:12:02");
            DateTime d10 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(d10);
            Console.WriteLine(d9);
            Console.WriteLine(d7);
            Console.WriteLine(d6);
            Console.WriteLine(d2);
            Console.WriteLine(d1.Ticks);
            Console.WriteLine(d3);

            Console.ReadKey();

        }
    }
}
