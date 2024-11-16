// Program to demonstrate  Interface With Properties In Inheritance in C# using Visual Studio.
// Programmer: Srushti Battise

namespace InterfaceWithProperties_01
{
    // Interface with a property definition
    public interface IVehicle
    {
        int speed { get; set; } // Property to get and set speed
        void Drive();
    }
    public class Car : IVehicle
    {
        public int speed { get; set; }
        public void Drive()
        {
            Console.WriteLine("Car is Driving:" + speed + "km/h");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate  Interface With Properties In Inheritance in C# using Visual Studio.\r\n");
            Car car = new Car();
            car.speed = 80;
            car.Drive();
        }
    }
}
