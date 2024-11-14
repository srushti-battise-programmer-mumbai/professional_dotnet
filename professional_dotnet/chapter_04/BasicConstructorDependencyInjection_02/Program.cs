// Program to demonstrate Basic Constructor Dependency Injection in C# using Visual Studio.
// Programmer: Srushti Battise

namespace BasicConstructorDependencyInjection_02
{
    // Define an interface for logging
    public interface ILogger
    {
        void Log(string message);
    }

    // Implementation of a Console Logger
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(" Program to demonstrate Basic Constructor Dependency Injection in C# using Visual Studio.\r\n");

            Console.WriteLine("Console Log: " + message);
        }
    }

    // A service that depends on ILogger
    public class Service
    {
        private readonly ILogger _logger;

        // Inject ILogger dependency via the constructor
        public Service(ILogger logger)
        {
            _logger = logger;
        }

        public void PerformTask()
        {
            _logger.Log("Performing a task...");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Dependency Injection
            ILogger logger = new ConsoleLogger();
            Service service = new Service(logger);

            service.PerformTask();
        }
    }
}


