using System.Text;
using System.Globalization;

namespace _10ex01_02_03_04.src.Entities
{
    internal class Employee
    {
        private string Name { get; set; }
        private int Hours { get; set; }
        private double ValuePerHour { get; set; }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment()
        {
            double result = Hours * ValuePerHour;
            return result;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Name} - $ {Payment().ToString("F2",CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}
