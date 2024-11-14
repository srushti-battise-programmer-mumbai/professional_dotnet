// Program to demonstrate Using IoC Container in C# using Visual Studio.
// Programmer: Srushti Battise

namespace UsingIoCContainer_01
{
    // Define the interface for message service
    public interface IMessageService
    {
        void SendMessage(string message);
    }

    // Concrete implementation of IMessageService (EmailService)
    public class EmailService : IMessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Email sent: " + message);
        }
    }

    // Notification service that depends on IMessageService
    public class Notification
    {
        private readonly IMessageService _messageService;

        // Constructor injection of IMessageService
        public Notification(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public void Notify(string message)
        {
            _messageService.SendMessage(message);
        }
    }

    // Basic implementation of a service container
    internal class ServiceCollection
    {
        private readonly Dictionary<Type, Func<object>> _services = new Dictionary<Type, Func<object>>();

        // Method to register a service
        public void AddTransient<TInterface, TImplementation>()
            where TImplementation : TInterface
        {
            _services[typeof(TInterface)] = () => Activator.CreateInstance(typeof(TImplementation));
        }

        // Method to resolve a service
        public T GetService<T>()
        {
            if (_services.ContainsKey(typeof(T)))
            {
                return (T)_services[typeof(T)]();
            }

            throw new InvalidOperationException($"Service of type {typeof(T)} not registered.");
        }

        // Method to build the provider (essentially finalize the container)
        public ServiceProvider BuildServiceProvider()
        {
            return new ServiceProvider(_services);
        }
    }

    // Provider that resolves dependencies from the ServiceCollection
    internal class ServiceProvider
    {
        private readonly Dictionary<Type, Func<object>> _services;

        public ServiceProvider(Dictionary<Type, Func<object>> services)
        {
            _services = services;
        }

        // Resolves and provides the requested service
        public T GetService<T>()
        {
            if (_services.ContainsKey(typeof(T)))
            {
                return (T)_services[typeof(T)]();
            }

            throw new InvalidOperationException($"Service of type {typeof(T)} not registered.");
        }
    }

    // Main program to set up DI and resolve services
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new service collection (DI container)
            var services = new ServiceCollection();

            // Register IMessageService with EmailService implementation
            services.AddTransient<IMessageService, EmailService>();

            // Register the Notification service
            services.AddTransient<Notification, Notification>();

            // Build the service provider from the service collection
            var serviceProvider = services.BuildServiceProvider();

            // Resolve the Notification service
            var notification = serviceProvider.GetService<Notification>();

            // Ensure the service is not null and send a notification
            if (notification != null)
            {
                notification.Notify("Using custom DI container!");
            }
            else
            {
                Console.WriteLine("Notification service not registered.");
            }
        }
    }
}
