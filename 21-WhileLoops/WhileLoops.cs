using System;

namespace ProgrammingExercisesIST
{
    class WhileLoops
    {
        static void Main(string[] args)
        {
            WaitBetween("Loop to ensure number is less than 100: ");

            // 1. Fix the condition of the WHILE loop so that the program works
            Console.WriteLine("Please enter a number less than 100 to continue...");
            int number = int.Parse(Console.ReadLine());
            while( ???? )
            {
                Console.WriteLine("Incorrect input, try again...");
                number = int.Parse(Console.ReadLine());
            }


            WaitBetween("WHILE loop to password protect a secret message: ");

            // 2. Write a WHILE loop to ensure the user enters a correct password of your choosing
            // Then, under the loop, output a message of your choice



            // Wait at end
            WaitAtEnd();
        }

        static void ExtensionTasks()
        {
            // 1. Extend the first task by also ensuring that the number is greater than 1 
            // 2. Try re-creating Fizz Buzz using a WHILE loop
        }

        static void Questions()
        {
            // 1. What is the shortcut for creating a WHILE loop?
            // 
            // 
            // 2. When would you use a WHILE loop?
            // 
            // 
        }

        static void Example()
        {
            // This is an example of creating a WHILE loop that goes from 1 to 10
            // Notice that you need to initialise your own counter variable and increment it
            //
            // int count = 1;
            // while(count < 11)
            // {
            //     Console.WriteLine(count);
            //     count++;
            // }

            // As you can tell, FOR loops are generally easier for counting
            // This is an example of where a WHILE loop might be handy
            //
            // string password = Console.ReadLine();
            // while(password != "hunter2")
            // {
            //     Console.WriteLine("Invalid password. Try again: ");
            //     password = Console.ReadLine();
            // }
            // RunSecureProgramAfterPasswordCheck();
        }

        static void Links()
        {
            // https://www.tutorialspoint.com/csharp/csharp_while_loop.htm
            // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/while
        }

        private static void WaitAtEnd()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private static void WaitBetween(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine(message);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
