using _10ex01_02_03_04.src.Entities.Enums;
using System.Globalization;

namespace _10ex01_02_03_04.src.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomFee { get; set; }

        public ImportedProduct(string name, double price, ProductType type, double customFee) : base(name, price, type)
        {
            CustomFee = customFee;
        }
        public double TotalPrice()
        {
            return Price + CustomFee;
        }
        public override string PriceTag()
        {
            string tag = $"{Name} $ {TotalPrice().ToString("F2", CultureInfo.InvariantCulture)} (Custom Fee: $ {CustomFee.ToString("F2", CultureInfo.InvariantCulture)}) ";
            return tag;
        }
    }
}
