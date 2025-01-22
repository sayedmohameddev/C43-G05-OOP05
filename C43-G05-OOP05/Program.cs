using System;

namespace C43_G05_OOP05
{
    //#region Q-01
    //public interface IShape
    //{
    //    double Area { get; }
    //    void DisplayShapeInfo();
    //}

    //public interface ICircle : IShape
    //{
    //    double Radius { get; set; }
    //}

    //public interface IRectangle : IShape
    //{
    //    double Length { get; set; }
    //    double Width { get; set; }
    //}

    //public class Circle : ICircle
    //{
    //    public double Radius { get; set; }
    //    public double Area => Math.PI * Radius * Radius;

    //    public Circle(double radius)
    //    {
    //        Radius = radius;
    //    }

    //    public void DisplayShapeInfo()
    //    {
    //        Console.WriteLine($"Circle: Radius = {Radius}, Area = {Area:F2}");
    //    }
    //}

    //public class Rectangle : IRectangle
    //{
    //    public double Length { get; set; }
    //    public double Width { get; set; }
    //    public double Area => Length * Width;

    //    public Rectangle(double length, double width)
    //    {
    //        Length = length;
    //        Width = width;
    //    }

    //    public void DisplayShapeInfo()
    //    {
    //        Console.WriteLine($"Rectangle: Length = {Length}, Width = {Width}, Area = {Area:F2}");
    //    }
    //}
    //#endregion

    //#region Question 02-01

    //public interface IAuthenticationService
    //{
    //    bool AuthenticateUser(string username, string password);
    //    bool AuthorizeUser(string username, string role);
    //}

    //public class BasicAuthenticationService : IAuthenticationService
    //{
    //    private readonly string _validUsername = "admin";

    //    private readonly string _validPassword = "password123";

    //    private readonly string _validRole = "Admin";

    //    public bool AuthenticateUser(string username, string password)
    //    {
    //        return username == _validUsername && password == _validPassword;
    //    }

    //    public bool AuthorizeUser(string username, string role)
    //    {
    //        return username == _validUsername && role == _validRole;
    //    }
    //}
    //#endregion

    //#region  Question 03-01
    //public interface INotificationService
    //{
    //    void SendNotification(string recipient, string message);
    //}
    //#endregion

    #region Question 03-02
    public interface INotificationService
    {
        void SendNotification(string recipient, string message);
    }
    #endregion

    #region تنفيذ الـ INotificationService في الكلاسات

    public class EmailNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"Sending email to {recipient}: {message}");
        }
    }

    public class SmsNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"Sending SMS to {recipient}: {message}");
        }
    }

    public class PushNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"Sending push notification to {recipient}: {message}");
        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            //ICircle circle = new Circle(5);
            //circle.DisplayShapeInfo();

            //IRectangle rectangle = new Rectangle(4, 7);
            //rectangle.DisplayShapeInfo();

            //IAuthenticationService authService = new BasicAuthenticationService();
            //string username = "admin";

            //string password = "password123";

            //if (authService.AuthenticateUser(username, password))
            //{
            //    string role = "Admin";

            //    Console.WriteLine(authService.AuthorizeUser(username, role));
            //}

            #region Question 02-02

            //IAuthenticationService authService = new BasicAuthenticationService();
            //string username = "admin";

            //string password = "password123";

            //if (authService.AuthenticateUser(username, password))
            //{
            //    string role = "Admin";
            //    Console.WriteLine(authService.AuthorizeUser(username, role) ? "Authorized" : "Not Authorized");
            //}
            //else
            //{
            //    Console.WriteLine("Authentication Failed");
            //}

            #endregion
            Console.ReadKey();
        }
    }
}
