using System;

namespace ProgrammingExercisesIST
{
    class Classes
    {
        static void Main(string[] args)
        {
            // First check out the example:
            Example();

            // Now, we are going to learn how to create our own classes
            // 1. Create a custom class
            // 2. Add private variables
            // 3. Add constructor
            // 4. Add methods

            // Wait at end
            WaitForKeyPress();
        }

        static void Example()
        {
            // There is an example class included in this project called 'Person.cs'
            // This allows us to do things like this:

            // Create a person
            Person p = new Person("John", "Doe", 42);

            // Do things...
            p.PrintInfo();
            p.Sit();
            p.Walk(100);
            p.Stand();
            p.Birthday();
            p.Walk(100);
            p.ChangeNamePrompt();
            p.PrintInfo();
        }

        static void Links()
        {
            // https://www.tutorialspoint.com/csharp/csharp_classes.htm
            // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/classes
        }

        private static void WaitForKeyPress()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
