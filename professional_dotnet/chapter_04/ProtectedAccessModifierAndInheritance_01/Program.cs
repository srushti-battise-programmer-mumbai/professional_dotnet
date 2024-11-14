// Program to demonstrate Protected Access Modifier And Inheritance in C# using Visual Studio.
// Programmer: Srushti Battise

namespace ProtectedAccessModifierAndInheritance_01
{
    public class Animal
    {
        // Protected field, accessible within the class and derived classes
        protected string sound = "Some sound";

        // Protected method
        protected void MakeSound()
        {
            Console.WriteLine("Animal Sound: " + sound);
        }
    }

    public class Dog : Animal
    {
        public void Bark()
        {
            // Accessing protected field and method from the base class
            sound = "Bark!";
            MakeSound();
        }
    }
    public class Cat : Animal
    {
        public void Meow()
        {
            // Accessing protected field and method from the base class
            sound = "Meow!";
            MakeSound();
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Protected Access Modifier And Inheritance in C# using Visual Studio.\n");
            Dog dog = new Dog();
            dog.Bark();
            Cat cat = new Cat();
            cat.Meow();
        }
    }
}
