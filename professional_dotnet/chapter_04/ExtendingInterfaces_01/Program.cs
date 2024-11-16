// Program to demonstrate  Extending Interfaces in C# using Visual Studio.
// Programmer: Srushti Battise

namespace ExtendingInterfaces_01
{
    // Base interface
    public interface Work
    {
        void Start();
    }
    public interface IAdvanced : Work
    {
        void Stop();
    }
    public class Machine
    {
        public void Start()
        {
            Console.WriteLine("Machine Started!");
        }
        public void Stop()
        {
            Console.WriteLine("Machine Stopped!");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate  Extending Interfaces in C# using Visual Studio.\r\n");
            Machine machine = new Machine();
            machine.Start();
            machine.Stop();
        }
    }
}
