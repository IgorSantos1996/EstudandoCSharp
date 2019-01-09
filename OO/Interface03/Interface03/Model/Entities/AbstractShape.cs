using Enums;
using Interface03.Model.Entities;

namespace Interface03.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }
        public abstract double Area();

    }
       
    
}
