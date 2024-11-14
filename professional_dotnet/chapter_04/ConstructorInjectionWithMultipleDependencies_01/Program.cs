// Program to demonstrate Constructor Injection With Multiple Dependencies_01 in C# using Visual Studio.
// Programmer: Srushti Battise

namespace ConstructorInjectionWithMultipleDependencies_01
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

    public class SmsService : IMessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("SMS sent: " + message);
        }
    }

    public class Notification
    {
        private readonly IMessageService _primaryService;
        private readonly IMessageService _backupService;

        public Notification(IMessageService primaryService, IMessageService backupService)
        {
            _primaryService = primaryService;
            _backupService = backupService;
        }

        public void Notify(string message)
        {
            _primaryService.SendMessage(message);
            _backupService.SendMessage(message);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            IMessageService emailService = new EmailService();
            IMessageService smsService = new SmsService();
            Notification notification = new Notification(emailService, smsService);

            notification.Notify("DI with multiple services!");
        }
    }
}