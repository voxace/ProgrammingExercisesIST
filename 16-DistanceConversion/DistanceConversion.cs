using System;

namespace ProgrammingExercisesIST
{
    class DistanceConversion
    {
        static void Main(string[] args)
        {
            // Runs the menu and stores the choice
            string choice = MainMenu();            

            if (choice == "1")
            {
                // 1. Create a function that converts km to miles
                // 2. Output the result of the function
                // NOTE: You can use the function "GetDistance" inside your new function
            }
            else if (choice == "2")
            {
                // 3. Create a function that converts miles to km
                // 4. Output the result of the function
                // NOTE: You can use the function "GetDistance" inside your new function
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Choice!");
            }

            // Wait for key press before exiting
            WaitForKeyPress();
        }

        private static int GetDistance(string unit)
        {
            Console.Write($"Enter distance (in {unit}) to convert: ");
            int distance = int.Parse(Console.ReadLine());
            return distance;
        }

        private static string MainMenu()
        {
            Console.Clear();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Kilometres to Miles");
            Console.WriteLine("2. Miles to Kilometres");
            string choice = Console.ReadLine();
            return choice;
        }

        private static void WaitForKeyPress()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
