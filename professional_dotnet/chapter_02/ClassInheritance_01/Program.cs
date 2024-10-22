// Program to create a Class Inheritance in C# with Visual Studio
// Programmer:Srushti Battise

// Defining a base class named "Animal"
public class Animal
{
    public string Name { get; set; }
    //Method in the base class
    public void Eat()
    {
        Console.WriteLine(Name + " is eating.");
    }
}

//Defining a derived class named "dog" inherited from Animal
public class Dog : Animal
{
    //Additional method specific to the dog class
    public void Bark()
    {
        Console.WriteLine(Name + " is barking.");
    }

}
//Defining a derived class named "Cat" inherited from Animal
public class Cat : Animal
{
    //Additional method specific to the cat class
    public void Meow()
    {
        Console.WriteLine(Name + " is purring.");
    }

}

namespace ClassInheritance_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to create a Class Inheritance in C# with Visual Studio\n");

            // Create an object of the Dog class
            Dog myDog = new Dog();

            // Create an object of the Cat class
            Cat myCat = new Cat();

            // Set the dog's name
            myDog.Name = "Buddy";

            // Set the Cat's name
            myCat.Name = "Melvin";

            // Call methods from both the base class and the derived class
            myDog.Eat();  // Output: Buddy is eating. (Inherited from Animal class)
            myDog.Bark(); // Output: Buddy is barking. (Defined in Dog class)

            // Call methods from both the base class and the derived class
            myCat.Eat();  // Output: Melvin is eating. (Inherited from Animal class)
            myCat.Meow(); // Output: Melvin is purring. (Defined in Cat class)

        }
    }
}
