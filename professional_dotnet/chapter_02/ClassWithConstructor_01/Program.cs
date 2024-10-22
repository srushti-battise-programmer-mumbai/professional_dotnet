// Program for creating class with constructor in C# with Visual Studio

// Programmer:Srushti Battise

//Defining a class named Person
public class Person
{
    //Field:Data That the Person Holds;
    public string name;
    public int age;
    //Constructor:Special Method to initialise Person's Data
    public Person(string personName, int personAge)
    {
        name = personName;
        //set the name field
        age = personAge;
        //set the age field
    }
    //Method:CALL TO SHOW PERSON'S DETAILS
    public void greet()
    {
        Console.WriteLine("Hello,I am " + name +" " +age + " years old.");
    }
}

namespace ClassWithConstructor_01
{
    internal class Program
    {
        public static void Main(string[] args)
        {
           //create an object of the person class using class constructor
           Person student = new Person ("ALICE" , 16);
            //CALL THE GREET METHOD
            student.greet();
            //THE OUTPUT:Hello,I am ALICE  and I am 16 Years Old.
        }
    }
}
