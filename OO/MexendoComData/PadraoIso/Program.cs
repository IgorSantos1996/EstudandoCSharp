using System;

namespace PadraoIso {
    class Program {
        static void Main(string[] args) {
            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);

            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);

            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);
            DateTime t1 = DateTime.Parse("2000-08-15 12:33:11");
            DateTime t2 = DateTime.Parse("2000-08-15T12:05:43Z");
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine("d1 : " + d1);
            Console.WriteLine("d1 Kind: " + d1.Kind);
            Console.WriteLine("d1 to Local " + d1.ToLocalTime());
            Console.WriteLine("d1 to UTC " + d1.ToUniversalTime());
            Console.WriteLine(t2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));


            Console.ReadKey();
        }
    }
}
