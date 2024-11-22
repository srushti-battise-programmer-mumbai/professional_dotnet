// Program to demonstrate Method Overriding Using Protected Members using C# in Visual Studio
// Programmer:Srushti Battise

namespace UsingProtectedMembers_01
{
    // Base class
    public class Appliance
    {
        protected string brand;

        public Appliance(string brandName)
        {
            brand = brandName;
        }
    }

    // Derived class
    public class WashingMachine : Appliance
    {
        public WashingMachine(string brandName) : base(brandName) { }

        public void DisplayBrand()
        {
            Console.WriteLine("Washing Machine Brand: " + brand);
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Program to demonstrate Method Overriding Using Protected Members using C# in Visual Studio\r\n");
            WashingMachine myWasher = new WashingMachine("LG");
            myWasher.DisplayBrand(); // Output: Washing Machine Brand: LG
        }
    }
}
