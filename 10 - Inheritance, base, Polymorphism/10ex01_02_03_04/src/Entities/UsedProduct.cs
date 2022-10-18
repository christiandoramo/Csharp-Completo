using System;
using _10ex01_02_03_04.src.Entities.Enums;
using System.Globalization;

namespace _10ex01_02_03_04.src.Entities
{
    internal class UsedProduct : Product
    {
        private DateTime ManufactureDate { get; set; }
        public UsedProduct(string name, double price,ProductType type,DateTime manufactureDate) : base(name, price, type)
        {
            ManufactureDate = manufactureDate;
        }
        public override string PriceTag()
        {
            string tag = $"{Name} (used) $ {Price.ToString("F2", CultureInfo.InvariantCulture)} (Manufacture date: {ManufactureDate.ToShortDateString()})";
            return tag;
        }
    }
}
