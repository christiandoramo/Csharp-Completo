using System;
namespace _09ex01_02_03.src.Entities.Classes
{
    class HourContract
    {
        public DateTime Date { get; private set; }
        private double ValuePerHours { get; set; }
        private int Hours { get; set; }

        public HourContract(DateTime date, double valuePerHours, int hours)
        {
            Date = date;
            ValuePerHours = valuePerHours;
            Hours = hours;
        }

        public double TotalValue()
        {
            double result = ValuePerHours * Hours;
            return result;
        }
    }
}
