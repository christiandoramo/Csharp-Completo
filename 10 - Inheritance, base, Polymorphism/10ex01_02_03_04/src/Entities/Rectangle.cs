
using _10ex01_02_03_04.src.Entities.Enums;

namespace _10ex01_02_03_04.src.Entities
{
    class Rectangle : Shape
    {
        private double Width { get; set; }
        private double Height { get; set; }

        public Rectangle(Color color, double width, double height) : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
        public override string ToString()
        {
            return base.ToString() + $" Shape: Rectangle";
        }
    }
}
