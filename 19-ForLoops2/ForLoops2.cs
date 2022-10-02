using System;

namespace ProgrammingExercisesIST
{
    class ForLoops2
    {
        static void Main(string[] args)
        {
            WaitBetween("Loop to find the number 42:");

            // 1. Create a FOR loop that goes from 0 to 99 by steps of 1
            // Inside the loop print a message only if the number = 42



            WaitBetween("Loop to find numbers divisible by 2:");

            // 2. Create a FOR loop that goes from 100 to 199 by steps of 3
            // Inside the loop print a message only if the number is divisible by 2



            // Wait at end
            WaitAtEnd();
        }

        static void ExtensionTasks()
        {
            // 1. Try expanding the selection into multiple 'else if' and 'else' statements
            // 2. Try changing the values of the loop counter from within the loop
        }

        static void Questions()
        {
            // 1. What is the shortcut for creating a FOR loop?
            // 
            // 
            // 2. What does the % operator do?
            // 
            // 
        }

        static void Example()
        {
            // This is an example of creating a loop that goes from 1 to 10
            // It will print out "Hello there" only if the loop counter = 7
            //
            // for (int num = 1; num < 11; num++)
            // {
            //     if(num == 7) 
            //     {
            //         Console.WriteLine("Hello there");
            //     }
            // }

            // This is an example of creating a loop that prints only numbers divisible by 3
            // It does this by using the modulo operator % which finds the remainder of a division
            //
            // for (int counter = 0; counter < 100; counter++)
            // {
            //     if(counter % 3 == 0)
            //     { 
            //         Console.WriteLine(counter);
            //     }
            // }
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
