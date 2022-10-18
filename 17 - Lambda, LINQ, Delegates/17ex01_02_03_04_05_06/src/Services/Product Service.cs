
using System.Globalization;

namespace _17ex01_02_03_04_05_06.src
{
    internal class ProductService
    {
        public ProductService()
        {
        }
        public void Average(List<Product> list, Func<Product, double> testWithAvg)
        {
            double avg = 0;
            foreach (Product product in list) avg += product.Price;
            avg /= list.Count;
            Console.WriteLine("Average: " + avg.ToString("F2", CultureInfo.InvariantCulture));
            List<string> belowAverage = new List<string>();
            foreach (Product product in list) if (testWithAvg.Invoke(product) < avg) belowAverage.Add(product.Name);
            // logo, test receberá um predicate que retorna true onde o P.Price é < do que avg
            belowAverage = belowAverage.DefaultIfEmpty("Nothing").OrderByDescending(x => x).ToList();

            foreach (string product in belowAverage) Console.WriteLine(product);
        }
    }
}
