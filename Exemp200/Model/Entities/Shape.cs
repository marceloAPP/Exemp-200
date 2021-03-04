using Exemp200.Model.Enums;

namespace Exemp200.Model.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }
        public abstract double Area();
    }
}
