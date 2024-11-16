// Program to demonstrate  Interface With Default Implementation in C# using Visual Studio.
// Programmer: Srushti Battise

namespace InterfaceWithDefaultImplementation_01
{
    public interface ILogger
    {
        // Default implementation provided for the Log method
        void Log(string message)
        {
            Console.WriteLine("Log:" + message);
        }
    }
    public class ConsoleLogger : ILogger
    {
        // No need to implement Log as it's already defined in the interface
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate  Interface With Default Implementation in C# using Visual Studio.\r\n");
            ILogger logger = new ConsoleLogger();
            logger.Log("System Initialized.");
        }
    }
}
