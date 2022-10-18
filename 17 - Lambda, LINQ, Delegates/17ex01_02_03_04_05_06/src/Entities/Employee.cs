using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace _17ex01_02_03_04_05_06.src
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }



        public Employee(string name, string email, double salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }

        public Employee()
        {
        }

        public override string ToString()
        {
            return Name + ", " + Email + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
