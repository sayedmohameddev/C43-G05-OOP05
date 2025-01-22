using System;

namespace C43_G05_OOP05
{
    #region Question 03 (4.5.6.7) INotificationService
    public interface INotificationService
    {
        void SendNotification(string recipient, string message);
    }
    #endregion

    #region تنفيذ الكلاسات الي بتعمل sms
    public class EmailNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"Simulating email to {recipient}: {message}");
        }
    }

    public class SmsNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"Simulating SMS to {recipient}: {message}");
        }
    }

    public class PushNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"Simulating push notification to {recipient}: {message}");
        }
    }
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            INotificationService emailService = new EmailNotificationService();
            INotificationService smsService = new SmsNotificationService();
            INotificationService pushService = new PushNotificationService();

            emailService.SendNotification("email@example.com", "This is an email notification.");
            smsService.SendNotification("1234567890", "This is an SMS notification.");
            pushService.SendNotification("User123", "This is a push notification.");

            Console.WriteLine("All notifications have been sent successfully!");
            Console.ReadKey();
        }
    }
}
