// Program to create a Comparing Record Instances in C# using Visual Studio

// Programmer: Srushti Battise

namespace ComparingRecordInstances_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Creating two instances of 'Person' record with the same values.
            Person person1 = new Person("Srushti", 50);
                Person person2 = new Person("Srushti", 50);

            // Using the equality operator (==) to check if both instances are equal.
            // Since records use value-based equality, this will return true.
            Console.WriteLine(person1 == person2);  // Output: True
        }
    }

    // A record named 'Person' that holds information about a person.
    // Records automatically provide value-based equality checks.
    public record Person(string Name, int Age);
}
