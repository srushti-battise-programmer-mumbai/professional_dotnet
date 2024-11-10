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
            List<(int Id, string Name)> employees = new List<(int Id, string Name)>
{
                (101,"Bob"),
                (102,"Charlie"),
                (103,"Alice")
            };
            // Iterate through each tuple in the list and print the details.
            foreach (var employee in employees)
            {
                Console.WriteLine($"ID:{employee.Id},Name:{employee.Name}");

            }

        }
    }
}
