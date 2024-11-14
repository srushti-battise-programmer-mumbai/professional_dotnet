// Program to demonstrate Private Protected Access Modifier InInheritance in C# using Visual Studio.
// Programmer: Srushti Battise

using PrivateProtectedAccessModifierInInheritance_01;

namespace PrivateProtectedAccessModifierInInheritance_01
{
    public class Shape
    {
        // private protected field, accessible in derived classes within the same assembly
        private protected string ShapeName = "Shape";
        // private protected method
        private protected void Describe()
        {
            Console.WriteLine("This is a " + ShapeName);
        }
    }

    public class Circle : Shape
    {
        public void ShowShape()
        {
            ShapeName = "Circle"; // Accessing private protected member
            Describe(); // Accessing private protected method
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    
    {
        Console.WriteLine("Program to demonstrate Private Protected Access Modifier InInheritance in C# using Visual Studio\n");
        Circle circle = new Circle();
        circle.ShowShape();
    }
}
