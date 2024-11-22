// Program to demonstrate Multi_LevelInheritance_Polymorphism using C# in Visual Studio
// Programmer:Srushti Battise

namespace Multi_LevelInheritance_Polymorphism_01
{
    // Base class
    public class Animal
    {
        public virtual void Move()
        {
            Console.WriteLine("The animal moves.");
        }
    }

    // Derived class 1
    public class Bird : Animal
    {
        public override void Move()
        {
            Console.WriteLine("The bird flies.");
        }
    }

    // Derived class 2
    public class Penguin : Bird
    {
        public override void Move()
        {
            Console.WriteLine("The penguin swims.");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Multi_LevelInheritance_Polymorphism using C# in Visual Studio\n");

            Animal myAnimal = new Animal();
            Bird myBird = new Bird();
            Penguin myPenguin = new Penguin();

            myAnimal.Move();   // Output: The animal moves.
            myBird.Move();     // Output: The bird flies.
            myPenguin.Move();  // Output: The penguin swims.
        }
    }
}
