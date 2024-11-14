// Program to demonstrate Private Access Modifier in C# using Visual Studio.
// Programmer: Srushti Battise

namespace PrivateAccessModifier_01
{
    public class BankAccount
    {
        // Private field, accessible only within the BankAccount class
        private decimal balance;
        // Public method to modify the private field
        public void Deposit(decimal amount)
        {
            // Changing private field within the class
            balance += amount;
        }
        public void ShowBalance()
        {
            Console.WriteLine("Balance:" + balance);
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate public Access Modifier in C# using Visual Studio.\n");
            BankAccount account = new BankAccount();
            // Accessing public method to modify private field
            account.Deposit(100.00m);
            // Accessing public method to display private field
            account.ShowBalance();
        }
    }
}
