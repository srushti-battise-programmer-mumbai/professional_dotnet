// Program to create Inheritance - One Class Inheriting from Another in C# with visual studio
// Programmer:Srushti Battise

namespace InheritanceOneClassInheritingfromAnother_01 
    {
    // Defining a base class named "Animal"
    public class Animal
    {
        public string Name { get; set; }

        // Method in the base class
        public void Eat()
        {
            Console.WriteLine(Name + " is eating.");
        }
    }

    // Defining a derived class named "Dog" that inherits from "Animal"
    public class Dog : Animal
    {
        // Additional method specific to the Dog class
        public void Bark()
        {
            Console.WriteLine(Name + " is barking.");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to create Inheritance - One Class Inheriting from Another in C# with visual studio\r\n");
            // Create an object of the Dog class
            Dog myDog = new Dog();

            // Set the dog's name
            myDog.Name = "Buddy";

            // Call methods from both the base class and the derived class
            myDog.Eat();  // Output: Buddy is eating. (Inherited from Animal class)
            myDog.Bark(); // Output: Buddy is barking. (Defined in Dog class)
        }
    }

}