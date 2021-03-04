using Exemp200.Model.Enums;
namespace Exemp200.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();  
    }
}
