// Program to create a class with multiple methods in C# with visual studio
// Programmer:Srushti Battise

// Defining a class named calculator

public class Calculator
{
    //Method to add two numbers
    public int Addition(int a, int b)
    {
        //Returns the sum  
        return a + b;
    }

    //Method to subtract two numbers
    public int Subtraction(int a, int b)
    {
        //Returns the difference  
        return a - b;
    }

    //Method to multiply two numbers
    public int Multiplication(int a, int b)
    {
        //Returns the product  
        return a * b;
    }

    //Method to divide two numbers
    public float Division(int a, int b)
    {
        //Returns the division 
        return a / b;
    }
}

namespace ClassWithMultipleMethods_01
{
   public class Program
    {
        public static void Main(string[] args)
        {
           

            // Creating an object named "myCalculator" using the class "Calculator"
            Calculator myCalculator = new Calculator();

            // Calling the method using object and dot operator 
            Console.WriteLine("Program to create a class with multiple methods in C# with visual studio\n");
            
            Console.WriteLine("Addition of two numbers: " + myCalculator.Addition(18, 27));
            Console.WriteLine("Subtraction of two numbers: " + myCalculator.Subtraction(18, 27));
            Console.WriteLine("Multiplication of two numbers: " + myCalculator.Multiplication(18, 27));
            Console.WriteLine("Division of two numbers: " + myCalculator.Division(67,40));

        }
    }
}
