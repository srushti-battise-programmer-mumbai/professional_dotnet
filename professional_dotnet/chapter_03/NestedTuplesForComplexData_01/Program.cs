// Program for Nested Tuples For Complex Data in C# using Visual Studio
// Programmer: Srushti Battise

namespace NestedTuplesForComplexData_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program for Nested Tuples For Complex Data in C# using Visual Studio\n");
            // Nested tuple for complex data representation
            var department = (Id: 1, Name: "Sales", Manager: (Id: 101, Name: "John"));

            // Accessing elements from the nested tuple
            Console.WriteLine("Department ID: " + department.Id);
            Console.WriteLine("Department Name: " + department.Name);
            Console.WriteLine("Manager ID: " + department.Manager.Id);
            Console.WriteLine("Manager Name: " + department.Manager.Name);

        }
    }
}
