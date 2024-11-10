// Program for Named Tuples Using Value Tuple in C# using Visual Studio
// Programmer: Srushti Battise

namespace NamedTuplesUsingValueTuple_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program for Named Tuples Using Value Tuple in C# using Visual Studio\n");
            // Create a ValueTuple with named elements for better readability.
            (int Id, string Name, double Salary) employee = (10, "Emma", 50000);

            // Access Tuple elements by name.
            // Output: Employee ID: 10
            Console.WriteLine("Employee Id:" + employee.Id);

            // Output: Employee Name: Emma
            Console.WriteLine("Employee Name:" + employee.Name);

            // Output: Employee Salary: 50000
            Console.WriteLine("Employee Salary:" + employee.Salary);
        }
    }
}
