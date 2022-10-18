using _10ex01_02_03_04.src.Entities.Enums;


namespace _10ex01_02_03_04.src.Entities
{
    class Circle : Shape
    {
        private double Radius { get; set; }

        public Circle(Color color, double radius) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return System.Math.Pow(Radius,2) * System.Math.PI;
        }
        public override string ToString()
        {
            return base.ToString() + $" Shape: Circle";
        }
    }
}
