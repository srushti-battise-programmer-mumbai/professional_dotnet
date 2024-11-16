// Program to demonstrate  Interface As Parameter in C# using Visual Studio.
// Programmer: Srushti Battise

namespace InterfaceAsParameter_01
{
    public interface IMovable
    {
        void Move();
    }
    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is Moving!");
        }
    }
    public class Aeroplane : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Aeroplane is Flying!");
        }
    }
    public class Program
    {
        // Method that accepts any IMovable type as parameter
        public static void StartMoving(IMovable movable)
        {
            movable.Move();
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate  Interface As Parameter in C# using Visual Studio.\r\n");
            Car car = new Car();
            Aeroplane aero = new Aeroplane();
            StartMoving(car);
            StartMoving(aero);
        }
    }
}
