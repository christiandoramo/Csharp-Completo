using System.Globalization;

namespace _10ex01_02_03_04.src.Entities
{
    class Company : TaxPayer
    {
        private int NumberOfEmployees { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double tax = NumberOfEmployees < 10 ? 16.0 / 100 * AnualIncome : 14.0 / 100 * AnualIncome;
            return tax;
        }

        public override string ToString()
        {
            return $"{base.ToString()}{Tax().ToString("F2", CultureInfo.InvariantCulture)}";

        }
    }
}

