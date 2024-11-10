// Program to create a Record With Immutable Properties And Methods in C# using Visual Studio

// Programmer: Srushti Battise




using System.ComponentModel.DataAnnotations;

namespace RecordWithImmutablePropertiesAndMethods_01
{
    public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Program to create a Record With Immutable Properties And Methods in C# using Visual Studio\n");
            
            //Creating an instance of the "Car" record
            Car car1 = new Car("Toyota","Camry");
            //Displaying Car Details
            Console.WriteLine(car1.GetCarDetails());  // Output: Make: Toyota, Model: Camry
        }
    }

    // Defining a record named 'Car'.
    // Records can also contain methods along with properties.
    public record Car(string Make, string Model)
    {
        // Method to return car details as a string.
        public string GetCarDetails()
        {
            return $"Make: {Make}, Model: {Model}";
        }
    }
}
    

