using System.Text;

namespace _10ex01_02_03_04.src.Entities
{
    abstract class TaxPayer
    {
        private string Name { get; set; }
        protected double AnualIncome { get; set; }

        protected TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Name}: $");
            return sb.ToString();
        }

        public abstract double Tax();
    }
}
