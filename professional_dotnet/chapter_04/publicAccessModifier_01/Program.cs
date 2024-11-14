// Program to demonstrate public Access Modifier in C# using Visual Studio.
// Programmer: Srushti Battise

namespace publicAccessModifier_01
{
    public class Car
    {
        //Public field accesible anywhere in the program
        public string Make;
        //Public method accesible anywhere
        public void DisplayMake()
        {
            Console.WriteLine("Car Make: " + Make);
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate public Access Modifier in C# using Visual Studio.\n");

            Car car = new Car();
            // Accessing public field
            car.Make = "Toyota";
            // Accessing public method
            car.DisplayMake();

        }
    }
}
