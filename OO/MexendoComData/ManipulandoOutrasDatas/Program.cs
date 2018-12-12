using System;

namespace ManipulandoOutrasDatas {
    class Program {
        static void Main(string[] args) {
            DateTime dt = new DateTime(2006, 8, 15, 13, 45, 58, 275);
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58);
            Console.WriteLine(dt);
            DateTime d2 = d.AddHours(2); // adicionei 2h
            Console.WriteLine("Data adicionada 2hs: " + d2);
            d2 = d.AddHours(1); // add 1h
            Console.WriteLine("Data adiciona +1h : "+ d2);
            d2 = d.AddDays(7);
            Console.WriteLine("Data adiciona 7dias" + d2);
            TimeSpan t =  d2.Subtract(d); // diferença entre as datas
            Console.WriteLine("Diferença entre as datas" + t);

            Console.WriteLine("1) Date: " + dt.Date); // extrair a data do meu objeto dt
            Console.WriteLine("2) Day: " + dt.Day); // extrair o dia do meu objeto dt
            Console.WriteLine("3) Year: " + dt.Year); // extrair o ano do meu meu objeto dt

           
            string s = d.ToLongDateString();
            string s2 = d.ToShortDateString(); // data no formato resumido
            string s3 = d.ToShortTimeString();// imprime hora e minuto
            string s4 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");
            
            Console.WriteLine(d.ToLongDateString());
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.ReadKey();
        }
    }
}
