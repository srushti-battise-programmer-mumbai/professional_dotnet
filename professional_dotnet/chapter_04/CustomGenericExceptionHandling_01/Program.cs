// Program to demonstrate Custom Generic Exception Handling in C# using Visual Studio.
// Programmer: Srushti Battise

namespace CustomGenericExceptionHandling_01
{
    class ExceptionHandler<T> where T : Exception
    {
        public void Handle(T exception)
        {
            Console.WriteLine($"Handling:{typeof(T).Name} Exception Message:{exception.Message}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Program to demonstrate Custom Generic Exception Handling in C# using Visual Studio.\n");

            //Demonstrating  the use of ExceptionHandler with different exception types
            ExceptionHandler<NullReferenceException> nullReferenceException = new ExceptionHandler<NullReferenceException>();

            nullReferenceException.Handle(new NullReferenceException(null));

            ExceptionHandler<InvalidOperationException> invalidOperationException = new ExceptionHandler<InvalidOperationException>();
            invalidOperationException.Handle(new InvalidOperationException("Invalid Operation Expression"));
        }

    }

}
