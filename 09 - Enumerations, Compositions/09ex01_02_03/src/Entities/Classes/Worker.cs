using _09ex01_02_03.src.Entities.Enums;
using System.Collections.Generic;

namespace _09ex01_02_03.src.Entities.Classes
{
    class Worker
    {
        private string Name { get; set; }
        private WorkerLevel Level { get; set; }
        private double BaseSalary { get; set; }
        private Department Department { get; set; }
        private List<HourContract> hcs = new List<HourContract>();

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            hcs.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            hcs.Remove(contract);

        }
        public double Income(int year, int month)
        {
            double result = BaseSalary;
            foreach (HourContract contract in hcs)
            {
                if (year == contract.Date.Year && month == contract.Date.Month)
                    result += contract.TotalValue();
            }
            return result;
        }
        public override string ToString()
        {
            return $"Name : {Name}\n" +
                $"Department: {Department.Name}";
        }
    }
}
