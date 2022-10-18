using System.Globalization;

namespace _10ex01_02_03_04.src.Entities
{
    class Individual : TaxPayer
    {
        private double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double tax = AnualIncome < 20000 ? 15.0 / 100 * AnualIncome : 25.0 / 100 * AnualIncome;
            tax -= (50.0 / 100 * HealthExpenditures);
            return tax;
        }

        public override string ToString()
        {
            return $"{base.ToString()}{Tax().ToString("F2",CultureInfo.InvariantCulture)}";
        }

    }
}
