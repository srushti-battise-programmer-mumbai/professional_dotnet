// Program to create  Class With Properties Advanced Fields in C# with visual studio
// Programmer:Srushti Battise
namespace ClassWithPropertiesAdvancedFields_01
{
    // Defining a class named "Book"
    public class Book
    {
        // Property: Like a field, but with more control
        private string title; // Private field, cannot be accessed directly

        // Public property to get and set the value of the title
        public string Title
        {
            get { return title; } // Getter method
            set { title = value; } // Setter method
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Create an object of the Book class
            Book myBook = new Book();

            // Set the title using the property
            myBook.Title = "The Adventures of Sherlock Holmes";

            // Get and print the title using the property
            Console.WriteLine("Book title: " + myBook.Title); // Output: The Adventures of Sherlock Holmes
        }
    }

}
