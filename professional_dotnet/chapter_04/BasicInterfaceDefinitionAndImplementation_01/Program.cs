// Program to demonstrate  Basic Interface Definition And Implementation in C# using Visual Studio.
// Programmer: Srushti Battise

namespace BasicInterfaceDefinitionAndImplementation_01
{
    // Define an interface named IShape
    public interface IShape
    {
        // Interface members - by default, they are public and abstract
        double CalculateArea();
    }
    // Implementing the IShape interface in a class Circle
    public class Circle : IShape
    {
        private double radius;
        // Constructor to initialize radius
        public Circle(double radius)
        {
            this.radius = radius;
        }
        // Implementing the CalculateArea method from IShape
        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate  Basic Interface Definition And Implementation in C# using Visual Studio.\r\n");
            Circle circle = new Circle(5);
            Console.WriteLine("Area of Circle:" + circle.CalculateArea());

        }
    }
}
