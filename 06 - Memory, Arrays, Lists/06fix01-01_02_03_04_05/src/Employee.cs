using System;

public class Employee
{
    public int Id;
    public string Name;
    public double Salary;

    public Employee(int id, string name, double salary)
    {
        this.Id = id;
        this.Name = name;
        this.Salary = salary;
    }

    public void increaseSalary(double percentage)
    {
        percentage /= 100;
        this.Salary += Salary * percentage;
    }

    public override string ToString()
    {
        return this.Id + ", " + this.Name + ", " + this.Salary + ".";
    }
}

