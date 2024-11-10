// Program for Enum And Switch Statements in C# using Visual Studio

// Programmer: Srushti Battise

namespace EnumAndSwitchStatements_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program for Enum And Switch Statements in C# using Visual Studio\n");
            // Assigning a value to 'TrafficSignal' enum variable.
            TrafficSignal signal = TrafficSignal.red;
            // Using a switch statement to perform different actions based on the enum value.
            switch (signal)
            {
                case TrafficSignal.red:
                    Console.WriteLine("Stop!");
                    break;
                case TrafficSignal.yellow:
                    Console.WriteLine("get ready!");
                    break;
                case TrafficSignal.green:
                    Console.WriteLine("go!");
                    break;
                default:
                    Console.WriteLine("Invalid Signal!");
                    break;
            }
        }
    }
    // Enum named 'TrafficSignal' that represents different states of a traffic light.
    public enum TrafficSignal
    {
        // Represents the "stop" state.
        red,
        // Represents the "get ready" state.
        yellow,
        // Represents the "go" state.
        green
    }
}
