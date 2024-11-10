// Program for Basic Enum Declaration And Usage in C# using Visual Studio

// Programmer: Srushti Battise

namespace BasicEnumDeclarationAndUsage_01
{
    public class Program
    {
      public static void Main(string[] args)
        {
            Console.WriteLine("Program for Basic Enum Declaration And Usage in C# using Visual Studio\n");
            // Declaring a variable of type 'DayOfWeek' and assigning it a value from the enum.
            DayOfWeek today = DayOfWeek.omi;
            // Displaying the value of the enum.
            // Output: Today is: Wednesday
            Console.WriteLine("Today is:" + today);
        }
    }

    // Declaring an enum type named 'DayOfWeek'.
    // An enum (short for "enumeration") is a distinct type that consists of a set of named constants called enumerators.
    public enum DayOfWeek
    {
        // Declaring an enum type named 'DayOfWeek'.
        // An enum (short for "enumeration") is a distinct type that consists of a set of named constants called enumerators.
        //0
        omi,
        //1
        Monday,
        //2
        Tuesday,
        //3 
        Wednesday,
        //4
        Thursday,
        //5 
        Friday,
        //6
        Saturday,
    }

}
