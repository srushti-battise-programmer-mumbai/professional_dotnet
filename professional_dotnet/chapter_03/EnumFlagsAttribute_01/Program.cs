// Program for Enum Flags Attribute in C# using Visual Studio

// Programmer: Srushti Battise

namespace EnumFlagsAttribute_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program for Enum Flags Attribute in C# using Visual Studio\n");
            // Combining multiple enum values using bitwise OR.
            FilePermissions permissions = FilePermissions.Read | FilePermissions.Write;
            // Checking if the combined value contains specific permissions.
            if ((permissions & FilePermissions.Read) == FilePermissions.Read)
            {
                // Output: Read permission granted.
                Console.WriteLine("Read Pemission Granted!");
            }
            if ((permissions & FilePermissions.Write) == FilePermissions.Write)
            {
                // Output: Write permission granted.
                Console.WriteLine("Write Pemission Granted!");
            }
        }
    }
}
// Enum named 'FilePermissions' with the [Flags] attribute.
// The [Flags] attribute allows enum values to be combined using bitwise operations.
[Flags]
public enum FilePermissions
{
    None = 0,// No permissions.
    Read = 1,// Binary: 0001
    Write = 2, // Binary: 0010
    Execute = 4,// Binary: 0100
    // Combine all permissions
    All = Read | Write | Execute
}