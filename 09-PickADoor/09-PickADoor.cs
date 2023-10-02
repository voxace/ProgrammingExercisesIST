using System;

namespace ProgrammingExercisesIST
{
    class Project_09_PickADoor
    {
        static void Main(string[] args)
        {
            // Ask the user to pick a door
            Console.WriteLine("Pick a Door: 1, 2 or 3");


            // 1. Input and store the result in a string variable


            /* 2. Use selection (if...else if...else) to print what is behind
                  each door. Make sure to print a warning message if the user 
                  picks something other than 1, 2 or 3.                       */


            // Wait at the end
            Console.ReadLine();
        }

        static void Questions()
        {
            /* 1. What is the purpose of the final ELSE statement in this program?
             * 
             * 
             * 
             * 2. What is the difference between the = operator and the == operator?
             * 
             * 
             * 
             */
        }

        static void ExtensionTasks()
        {
            // 1. Use more else if's to create more doors
            // 2. Use what you have learnt to create a customised message to the user (e.g. with their name)
            // 3. Research online to figure out how to choose a random number. Use this number to pick a door.
        }

        static void Example()
        {
            /* This is an example of the program's output:
             * 
             * Pick a Door: 1, 2 or 3
             * 2
             * You win a Car!
             */
        }

        static void Links()
        {
            // Selection: https://www.tutorialspoint.com/csharp/csharp_decision_making.htm
            // Selection: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/if-else
            // Random: https://www.c-sharpcorner.com/article/generating-random-number-and-string-in-C-Sharp/
        }
    }
}