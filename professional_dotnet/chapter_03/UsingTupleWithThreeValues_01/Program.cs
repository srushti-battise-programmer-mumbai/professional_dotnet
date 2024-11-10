// Program to Using Tuple With Three Values in C# using Visual Studio
// Programmer: Srushti Battise

namespace UsingTupleWithThreeValues_01
{
    public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine(" Program to Creating Basic Tuple in C# using Visual Studio\n");
            // Call the GetEmployeeData method which returns a Tuple with ID and Name.
            var employee = GetEmployeeData();

            // Output: Employee ID: 102
            Console.WriteLine("Employee Id:" +employee.Item1);

            // Output: Employee Name: Sara
            Console.WriteLine("Employee Name:" +employee.Item2);

            // Method that returns a Tuple containing an int and a string.
        }
        public static Tuple<int,string> GetEmployeeData()
        {
            // Return a new Tuple object with ID and Name.
            return new Tuple<int,string>(102,"Sara");
        }
    }
}
