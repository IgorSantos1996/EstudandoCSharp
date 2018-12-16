using System;
using Composition02.Entities;

namespace Composition02
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow that's awesome");
            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zeland", "I'm going to visit!",
                12);

            p1.AddCommment(c1); ;
            p1.AddCommment(c2);

            Comment c3 = new Comment("Good Night");
            Comment c4 = new Comment("May the Force be with you");

            Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                5);
            p2.AddCommment(c3);
            p2.AddCommment(c4);
            Console.ReadLine();
        }
    }
}
