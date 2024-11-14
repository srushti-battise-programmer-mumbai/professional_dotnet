// Program to demonstrate Access Modifiers In Properties In Inheritance in C# using Visual Studio.
// Programmer: Srushti Battise

namespace AccessModifiersInProperties_01
{
    public class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Person(string PersonName)
        {
            Name = PersonName;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Access Modifiers In Properties In Inheritance in C# using Visual Studio.\r\n");
            Person person = new Person("John");
            Console.WriteLine("Person Name:" + person.Name);
        }
    }
}
