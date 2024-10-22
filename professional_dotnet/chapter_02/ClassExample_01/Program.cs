// Program for creating a simple class in C# with Visual Studio

// Programmer:Srushti Battise

// Defining a class named Car
public class Car
{
    //Field:Data that the Car holds

    //color of the car
    public string color;
    //speed of the car
    public int speed;

    //Method:An action that the car can perfor,
    public void Drive()
    {
        //This method will print a message when called
        Console.WriteLine("The car is Driving at speed" + "speed" + "km/h");
    }
}

namespace ClassExample_01
{
    //Using the Car class to create an object
    public class Program

    {
        public static void Main(string[] args)
        {
            //Create an Object of the Car class
            Car myCar = new Car();
            //This is like building a new robot from the blueprint
            //Assign values to the fields of the Object
            myCar.color = "red";
            myCar.speed = 100;
            //Call the Method to perfoem the action
            myCar.Drive();
            //The Output:The car Driving at 100 km/h.

        }

    }
}
