using System.Globalization;
namespace _17ex01_02_03_04_05_06.src
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name + ", " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

        public static bool BoolByPrice(Object obj)
        {
            if (!(obj is Product)) throw new ArgumentException("obj is not Type List Product");
            Product product = obj as Product;
            bool result = product.Price >= 100.0 ? true : false;
            return result;
        }
        public static void ValueAugment(Object obj)
        {
            if (!(obj is Product)) throw new ArgumentException("obj is not Type Product");
            Product product = obj as Product;
            product.Price *= 1.1;

        }
        public static double SumT(List<Product> products, Func<Product, bool> test)
        {
            double sum = 0;
            foreach (Product product in products)
            {
                if (test.Invoke(product))
                {
                    sum += product.Price;
                }
            }
            return sum;
        }

        // as seen, many static methods were created within the Product class,
        // for this and other reasons it is necessary to create
        // a Product Service class to organize it better.
    }
}
