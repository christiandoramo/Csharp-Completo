using System.Globalization;
using System;

namespace _14ex01_02_03.src
{
    //Interface IComparable utiliza CompareTo para fazer as comparações do Sort() por exemplo. Implementaçao obrigatoria
    internal class EmployeeData : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"{Name},{Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public int CompareTo(object obj)
        {
            if (!(obj is EmployeeData))
            {
                throw new ArgumentException("argument exception: other object is not employeedata can't compare");
            }
            EmployeeData other = obj as EmployeeData;
            return Name.CompareTo(other.Name);
        }
    }
}
