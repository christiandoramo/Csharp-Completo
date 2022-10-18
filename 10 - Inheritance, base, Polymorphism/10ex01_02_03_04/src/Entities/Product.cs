using System.Globalization;
using _10ex01_02_03_04.src.Entities.Enums;

namespace _10ex01_02_03_04.src.Entities
{
    internal class Product
    {
        protected string Name { get; set; }
        protected double Price { get; set; }
        protected ProductType Type { get; set; }

        public Product(string name, double price, ProductType type)
        {
            Name = name;
            Price = price;
            Type = type;
        }

        public virtual string PriceTag()
        {
            string tag = $"{Name} $ {Price.ToString("F2", CultureInfo.InvariantCulture)}";
            return tag;
        }
    }
}
