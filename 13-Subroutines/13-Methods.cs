using System;

namespace ProgrammingExercisesIST
{
    class Project_13_Methods
    {
        static void Main(string[] args)
        {
            // 1. Create a method called "SayHello" to print the message "Hello World"


            // The "Wait" method is called here
            Wait();

        }

        static void Wait()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void Questions()
        {
            /* 1. What is a method?
             * 
             * 
             * 
             * 2. What does the 'void' keyword mean?
             * 
             * 
             * 
             * 3. What does it mean to 'call' a method? 
             * 
             * 
             * 
             */
        }

        static void ExtensionTasks()
        {
            // 1. Try creating extra methods that do whatever you like
            // 2. Try calling the methods multiple times
            // 3. Try calling methods from within another
        }

        static void Links()
        {
            // https://www.tutorialspoint.com/csharp/csharp_methods.htm
            // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods
        }
    }
}