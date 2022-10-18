namespace _10ex01_02_03_04.src.Entities
{
    internal class OutSourcedEmployee : Employee
    {
        private double AdditionalCharge { get; set; }
        public OutSourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }
        public override double Payment()
        {
            double result = base.Payment() + 1.1 * AdditionalCharge;
            return result;
        }
    }
}
