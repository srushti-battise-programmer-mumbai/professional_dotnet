// Program for Tuple In Collection in C# using Visual Studio
// Programmer: Srushti Battise

namespace TupleInCollection_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program for Tuple In Collectionin C# using Visual Studio\n");
            // Create a list of tuples to hold employee data.
            List<(int Id, string Name)> employees_list_of_tuples = new List<(int Id, string Name)>
            {
                (101,"Bob"),
                (102,"Charlie"),
                (103,"Alice")
            };
            // Iterate/traverse through each element of the tuples list and print the same.
            
            foreach (var current_employee in employees_list_of_tuples)
            {
                Console.WriteLine($"ID:{current_employee.Id},Name:{current_employee.Name}");
            }

        }
    }
}
