// Program to create Using With Expression For NonDestructive Mutation in C# using Visual Studio
// Programmer: Srushti Battise

namespace UsingWithExpressionForNonDestructiveMutation_01
{
    public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine(" Program to create Using With Expression For NonDestructive Mutation in C# using Visual Studio\n");
            // Creating an instance of "Student" record
            Student student1 = new Student("Srushti","Physics");
            // Using the "with" expression to create a new record from "student1" with differnt major
            Student student2 = student1 with { Major = "Mathematics" };
            // Displaying details of both students

            // Output: Student { Name = Srushti, Major = Physics }
            Console.WriteLine(student1);
            // Output: Student { Name = Srushti, Major = Mathematics }
            Console.WriteLine(student2);
        }
    }
}
// Record named "Student" Contains the Name and Major Properties
// Using the "with" expression to create a new record from the existing record with modifications
public record Student(string Name, string Major);
