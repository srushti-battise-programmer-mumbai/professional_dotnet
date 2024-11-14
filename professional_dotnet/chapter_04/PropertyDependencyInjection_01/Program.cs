// Program to demonstrate Property Dependency Injection in C# using Visual Studio.
// Programmer: Srushti Battise

using System;

namespace PropertyDependencyInjection_01
{
    public interface IMessageService
    {
        void SendMessage(string message);
    }

    public class EmailService : IMessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Email sent: " + message);
        }
    }

    public class Notification
    {
        public IMessageService MessageService { get; set; }

        public void Notify(string message)
        {
            MessageService?.SendMessage(message);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Notification notification = new Notification
            {
                MessageService = new EmailService()
            };

            notification.Notify("Property Injection Example");
        }
    }
}
