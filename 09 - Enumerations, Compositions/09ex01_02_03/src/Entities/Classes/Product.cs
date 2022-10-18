using System.Globalization;
namespace _09ex01_02_03.src.Entities.Classes
{
    class Product
    {
        private string Name { get; set; }
        private double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name}, ${Price.ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
