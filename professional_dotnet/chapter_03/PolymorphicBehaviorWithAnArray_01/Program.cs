// Program to demonstrate  Polymorphic Behavior With An Array_01 in C# using Visual Studio
// Programmer: Srushti Battise

namespace PolymorphicBehaviorWithAnArray_01
{
    using System;

    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape.");
        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle.");
        }
    }

    public class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a square.");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Shape[] shapes = { new Circle(), new Square(), new Shape() };

            foreach (Shape shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
