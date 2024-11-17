// Program to demonstrate Abstract Classes And Polymorphism in C# using Visual Studio
// Programmer: Srushti Battise

namespace AbstractClassesAndPolymorphism_01
{
    using System;

    public abstract class Employee
    {
        public string Name { get; set; }

        public Employee(string name)
        {
            Name = name;
        }

        // Abstract method
        public abstract void CalculateSalary();
    }

    public class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(string name) : base(name) { }

        public override void CalculateSalary()
        {
            Console.WriteLine($"{Name} gets a fixed salary.");
        }
    }

    public class PartTimeEmployee : Employee
    {
        public PartTimeEmployee(string name) : base(name) { }

        public override void CalculateSalary()
        {
            Console.WriteLine($"{Name} gets paid by the hour.");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Employee[] employees = { new FullTimeEmployee("John"), new PartTimeEmployee("Doe") };

            foreach (Employee employee in employees)
            {
                employee.CalculateSalary();
            }
        }
    }
}