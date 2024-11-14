// Program to demonstrate Fibonacci Series in C# with Visual Studio
// Programmer:Srushti Battise

namespace FibonacciSeries_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Fibonacci Series in C# with Visual Studio\n");
            int first_term = 0;
            int second_term = 1;
            int third_term = 0;
            Console.WriteLine("Enter the Total number of terms:");
            int number_of_terms = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(first_term);
            Console.WriteLine(second_term);

            for (int loop_counter = 0; loop_counter < number_of_terms; loop_counter++)
            {
                third_term = first_term + second_term;
                Console.WriteLine(third_term);
                first_term = second_term;
                second_term = third_term;
            }
        }
    }
}
