// Program to demonstrate Method Overriding using C# in Visual Studio
// Programmer:Srushti Battise

public class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("Animal makes a sound.");
    }
}

// Derived class
public class Cat : Animal
{
    public override void Sound()
    {
        Console.WriteLine("The cat says: Meow");
    }
}

namespace MethodOverriding_01
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Method Overriding using C# in Visual Studio\n");

            Animal myAnimal = new Animal();
            Cat myCat = new Cat();

            myAnimal.Sound(); // Output: Animal makes a sound.
            myCat.Sound();    // Output: The cat says: Meow
        }
    }
}