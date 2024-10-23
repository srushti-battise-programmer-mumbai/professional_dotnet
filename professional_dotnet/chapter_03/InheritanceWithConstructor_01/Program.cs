// Program to create Inheritance with Constructor using C# in Visual Studio
// Programmer:Srushti Battise

// Base class
public class Vehicle
{
    public string Brand;

    // Constructor 
    public Vehicle(string brand)
    
    {
        Brand = brand;
    }

    public void ShowBrand()
    {
        Console.WriteLine("Vehicle Brand:" + Brand);
    }
}
//Derived Class
public class Car : Vehicle
{
    public Car(string brand) : base(brand) { }
}

namespace InheritanceWithConstructor_01 { }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to create Inheritance with Constructor using C# in Visual Studio\n");

            Car myCar = new Car("Toyota");
            // Output:Vehicle Brand:Toyota
            myCar.ShowBrand();
        }
    }

