using System;

public class Employee
{
    public string Name { get; set; }
    public int BasicSalary { get; set; }

    public virtual int CalculateSalary()
    {
        // Common salary calculation logic
        return BasicSalary;
    }
}

public class Manager : Employee
{
    public override int CalculateSalary()
    {
        // Manager's salary calculation logic
        return BasicSalary + 5000; // Additional bonus for managers
    }
}

public class Developer : Employee
{
    public override int CalculateSalary()
    {
        // Developer's salary calculation logic
        return BasicSalary + 2000; // Additional bonus for developers
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee john = new Employee { Name = "John", BasicSalary = 50000 };
        Manager sarah = new Manager { Name = "Sarah", BasicSalary = 60000 };
        Developer mike = new Developer { Name = "Mike", BasicSalary = 55000 };

        Console.WriteLine(john.Name + "'s salary: $" + john.CalculateSalary());
        Console.WriteLine(sarah.Name + "'s salary: $" + sarah.CalculateSalary());
        Console.WriteLine(mike.Name + "'s salary: $" + mike.CalculateSalary());
    }
}
