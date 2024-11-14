// Program to demonstrate Access Modifiers In Nested Classes_01 InInheritance in C# using Visual Studio.
// Programmer: Srushti Battise

namespace AccessModifiersInNestedClasses_01
{
    internal class OuterClass
    {
        private class InnerClass
        {
            // Private method within nested class
            public void Inner()
            {
                Console.WriteLine("Inside InnerClass Method");
            }
        }
        public void AccessInnerClass()
        {
            InnerClass inner = new InnerClass();
            // Accessing private nested class method
            inner.Inner();
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Access Modifiers In Nested Classes_01 InInheritance in C# using Visual Studio.\n");
                OuterClass outer = new OuterClass();
                outer.AccessInnerClass();
        }
    }
}
