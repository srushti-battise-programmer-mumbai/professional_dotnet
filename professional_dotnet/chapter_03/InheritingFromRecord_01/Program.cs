// Program for Inheriting From Record in C# using Visual Studio

// Programmer: Srushti Battise

using System;

namespace InheritingFromRecord_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program for Inheriting From Record in C# using Visual Studio\n");

            // Creating an instance of 'Employee' record.
            Employee employee1 = new Employee("Srushti", 20000);

            // Creating an instance of 'Manager' record, which inherits from 'Employee'.
            Manager manager1 = new Manager("Priyanka", 50000, "Sales");

            // Displaying details of employee and manager.
            // Output: Employee { Name = John, Salary = 50000 }
            Console.WriteLine(employee1);

            // Output: Employee { Name = John, Salary = 50000, Department = Sales }
            Console.WriteLine(manager1);

        }
    }

    // Base record 'Employee' with properties 'Name' and 'Salary'.
    // Records can serve as base types for other records, allowing inheritance.
    public record Employee(string Name, int Salary);

    // Derived record 'Manager' inherits from 'Employee' and adds a new property 'Department'.
    // This demonstrates how records can be extended to include additional data.
    public record Manager(string Name, int Salary, string Department) : Employee(Name, Salary);
}