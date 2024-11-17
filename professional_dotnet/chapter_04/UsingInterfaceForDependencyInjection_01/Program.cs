// Program to demonstrate Using Interface For Dependency Injection in C# using Visual Studio.
// Programmer: Srushti Battise

using System;
namespace UsingInterfaceForDependencyInjection_01
{
    // Define the interface
    public interface IMessageService
    {
        void SendMessage(string message);
    }
    // Implement the interface in EmailService
    public class EmailService : IMessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Email sent: " + message);
        }
    }
    // Implement the interface in SmsService
    public class SmsService : IMessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("SMS sent: " + message);
        }
    }
    // Notification class depends on IMessageService
    public class Notification
    {
        private readonly IMessageService _messageService;
        public Notification(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public void Notify(string message)
        {
            _messageService.SendMessage(message);
        }
    }

    // Program execution starts here
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Using Interface for Dependency Injection in C# using Visual Studio.\n");

            // Dependency injection using EmailService
            Notification notification = new Notification(new EmailService());
            notification.Notify("Hello, this is a test notification.");

            // Dependency injection using SmsService
            Notification smsNotification = new Notification(new SmsService());
            smsNotification.Notify("Hello, this is an SMS notification.");
        }
    }
}
