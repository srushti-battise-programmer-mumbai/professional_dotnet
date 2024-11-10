// Program for Enum With Custom Values in C# using Visual Studio

// Programmer: Srushti Battise


using System.Security.Cryptography.X509Certificates;

namespace EnumWithCustomValues_01
{
   public class Program
    {
       public  static void Main(string[] args)
        {
            Console.WriteLine("Program for Enum With Custom Values in C# using Visual Studio\n");
            // Creating a variable of 'StatusCode' and setting it to a specific value.
            StatusCode code = StatusCode.Error;
            // Checking the value of the enum using a conditional statement.
            if(code == StatusCode.Error)
            {
                // Output: An error occurred.
                Console.WriteLine("An Error Occured.");
            }
        }
    }
}
// Declaring an enum named 'StatusCode' with custom integer values.
// Enum values can be explicitly assigned, allowing custom values instead of the default sequence.
public enum StatusCode
{
    // The value 200 is typically used for a successful operation.
    Successful = 200,
    // A custom value of 300 for warning status.
    Warning = 300,
    //The value 500 is often used to indicate an error.
    Error = 500
}

