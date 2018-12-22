using ClassesAbstratas01.Entities.Enums;

namespace ClassesAbstratas01.Entities
{
    abstract class Shape
    {

        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
