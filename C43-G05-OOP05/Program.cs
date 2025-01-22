using System;

namespace C43_G05_OOP05
{
    #region Q-01
    public interface IShape
    {
        double Area { get; }
        void DisplayShapeInfo();
    }

    public interface ICircle : IShape
    {
        double Radius { get; set; }
    }

    public interface IRectangle : IShape
    {
        double Length { get; set; }
        double Width { get; set; }
    }

    public class Circle : ICircle
    {
        public double Radius { get; set; }
        public double Area => Math.PI * Radius * Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle: Radius = {Radius}, Area = {Area:F2}");
        }
    }

    public class Rectangle : IRectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Area => Length * Width;

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle: Length = {Length}, Width = {Width}, Area = {Area:F2}");
        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            ICircle circle = new Circle(5);
            circle.DisplayShapeInfo();

            IRectangle rectangle = new Rectangle(4, 7);
            rectangle.DisplayShapeInfo();

            Console.ReadKey();
        }
    }
}
