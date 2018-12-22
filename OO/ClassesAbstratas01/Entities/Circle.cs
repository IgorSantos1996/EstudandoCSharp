using ClassesAbstratas01.Entities.Enums;
using System;


namespace ClassesAbstratas01.Entities
{
    class Circle : Shape
    {
        public double  Radius { get; set; }
        public Circle (double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

    }
}
