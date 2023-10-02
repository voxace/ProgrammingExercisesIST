using System;

namespace ProgrammingExercisesIST
{
    class Project_16_DistanceConversion
    {
        static void Main(string[] args)
        {
            // Runs the menu and stores the choice
            string choice = MainMenu();            

            if (choice == "1")
            {
                // 1. Create a function that converts km to miles
                // 2. Output the result of the function
                // NOTE: You can use the function "GetDistance" before or inside your new function
                double km = GetDistance("Km");
                double miles = ConvertKmToMiles(km);
                Console.WriteLine($"That is {miles} miles");

            }
            else if (choice == "2")
            {
                // 3. Create a function that converts miles to km
                // 4. Output the result of the function
                // NOTE: You can use the function "GetDistance" before or inside your new function


            }
            else
            {
                ErrorMessage("Invalid Choice!");
            }

            // Wait for key press before exiting
            WaitForKeyPress();
        }

        private static double ConvertKmToMiles(double km)
        {
            double miles = km / 1.6;
            return miles;
        }

        // Asks the user to enter a distance in the unit specified
        private static double GetDistance(string unit)
        {
            Console.Write($"Enter distance (in {unit}) to convert: ");
            double distance = int.Parse(Console.ReadLine());
            return distance;
        }

        // Shows the menu options to the user
        private static string MainMenu()
        {
            Console.Clear();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Kilometres to Miles");
            Console.WriteLine("2. Miles to Kilometres");
            string choice = Console.ReadLine();
            return choice;
        }

        // Waits for the user to press any key
        private static void WaitForKeyPress()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        // Displays an error message in red text
        private static void ErrorMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void Questions()
        {
            /* 1. Explain in detail what this line of code does:  string choice = MainMenu();
             * 
             * 
             * 
             * 
             */
        }

        static void ExtensionTasks()
        {
            // 1. Try adding options for 'centimetres to inches' and 'inches to centimetres'
        }
    }
}
