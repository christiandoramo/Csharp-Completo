using _10ex01_02_03_04.src.Entities.Enums;
using System.Text;
using System.Globalization;

namespace _10ex01_02_03_04.src.Entities
{
    abstract class Shape
    {
        private Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }
        public abstract double Area();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Area: {Area().ToString("F2", CultureInfo.InvariantCulture)}");
            sb.Append($", Color: {Color},");
            return sb.ToString();
        }
    }
}
