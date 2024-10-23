// Base class
public class Animal
{
    public void Eat()
    {
        Console.WriteLine("This animal is eating.");
    }
}

// Derived class
public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("The dog is barking.");
    }
}

namespace SimpleInheritance_01 {
    public class Program
    {
        public static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.Eat();  // Output: This animal is eating.
            myDog.Bark(); // Output: The dog is barking.
        }
    }
}