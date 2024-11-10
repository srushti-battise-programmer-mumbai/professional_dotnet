// Program to create a Basic Record Declarations in C# using Visual Studio
// Programmer: Srushti Battise

namespace BasicRecordDeclaration_01
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Program to create a Basic Record Declarations in C# using Visual Studio\n");

            // Creating an instance of the 'Person' record.
           Person srushti = new Person("Srushti",21);

            // Displaying the properties of the record.
            // Output: Name: John, Age: 30
            // Using the String interpolation with $ symbol for string formatting
            Console.WriteLine($"Name: {srushti.Name}, Age: {srushti.Age}");
        }
    }
    // Declaring a simple record named 'Person'.
    // A record is a reference type that provides a way to encapsulate data.
    // Records are immutable by default, meaning their values cannot be changed once assigned.
public record Person(string Name,int Age);
}
