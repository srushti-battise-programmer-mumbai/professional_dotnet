// Program to create a class with properties in C# with visual studio
// Programmer:Srushti Battise

// Defining a class named Book
using System.Reflection.Metadata.Ecma335;

public class Book
{
    private string title;

    // Property:Its like a field but with more control
    // Private field cannot be accesed directly
    public string Title 
    // Public property is used to get and set the value of the class
    {
        // Getter method
        get {return title;} 
        // Setter method
        set {title = value;}
    }
}


namespace ClassWithProperties_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create an object of the book class
            Book myBook= new Book();

            // Set the title using the property
            myBook.Title = "The adventure of Sherlock Holmes";
            Console.WriteLine("The Book Title:" + myBook.Title);
            //The output:The adventure of the Sherlock Holmes
        }
    }
}
