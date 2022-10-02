using System;

namespace ProgrammingExercisesIST
{
    class ForLoops
    {
        static void Main(string[] args)
        {
            WaitBetween("From 5 to 15:");

            // 1. Fix the following FOR loop so that it prints from 5 to 15
            for (int i = 9999; i < 9999; i++)
            {
                Console.WriteLine(i);
            }

            WaitBetween("From 20 down to 1:");

            // 2. Fix the following loop so that it counts DOWN
            for (int x = 20; x > 0; x++)
            {
                Console.WriteLine(x);
            }

            WaitBetween("From 90 to 100 by two's:");

            // 3. Make the following loop increment by 2 each time
            for (int count = 90; count <=100; count++)
            {
                Console.WriteLine(count);
            }

            WaitBetween("From 60 down to 30 by three's:");

            // 4. Make your own FOR loop (press TAB twice quickly) 
            // that counts from 60 down to 30 in steps of 3


            // Wait at end
            WaitAtEnd();
        }

        static void ExtensionTasks()
        {
            // 1. Try using  user input before the loop starts to control the way it works 
            // 2. Try using selection inside the loop to do different things based on the counter
        }

        static void Questions()
        {
            // 1. Explain what each part of the FOR loop does:
            //  a) int i = 0;
            //     
            //     
            //  b) i <= 100;
            //     
            //     
            //  c) i++
            //     
            //     
        }

        static void Example()
        {
            // Some example FOR loops: Notice that the counter variable can be called anything

            // This is an example of creating a loop that print the numbers from 1 to 10
            //
            // for (int num = 1; num < 11; num++)
            // {
            //     Console.WriteLine(num);
            // }

            // This is an example of creating a loop that print the numbers from 10 down to 1
            //
            // for (int whatever = 10; whatever > 0; whatever--)
            // {
            //     Console.WriteLine(whatever);
            // }
        }

        static void Links()
        {
            // https://www.tutorialspoint.com/csharp/csharp_for_loop.htm
            // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/for
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
