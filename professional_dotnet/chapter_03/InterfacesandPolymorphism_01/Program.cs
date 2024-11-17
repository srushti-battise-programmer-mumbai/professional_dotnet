// Program to demonstrate Interfaces and Polymorphism in C# using Visual Studio
// Programmer: Srushti Battise
namespace InterfacesandPolymorphism_01
{
    using System;
    public interface IMovable
    {
        void Move();
    }

    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("The car drives on the road.");
        }
    }

    public class Airplane : IMovable
    {
        public void Move()
        {
            Console.WriteLine("The airplane flies in the sky.");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            IMovable[] movables = { new Car(), new Airplane() };

            foreach (IMovable movable in movables)
            {
                movable.Move();
            }
        }
    }

}