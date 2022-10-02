using System;

namespace ProgrammingExercisesIST
{
    class Project_22_EvenBetterAreaCalculator
    {
        static void Main(string[] args)
        {
            // 1. Create a string called 'choice' and assign it the empty string ""


            // 2. Surround the entire program below (except for WaitForKeyPress) within a while loop
            // The condition of the WHILE loop should be that it runs only when choice doesn't equal 4
            // If the user chooses 1, 2 or 3 a calculation will run, if they choose 4 the program will exit


            // -------------- CODE TO LOOP -------------- //

            // Menu
            choice = RunMenuOptions();

            // Options
            if (choice == "1")
            {
                CalculateCircle();
            }
            else if (choice == "2")
            {
                CalculateRectangle();
            }
            else if (choice == "3")
            {
                CalculateTriangle();
            }
            else
            {
                ErrorMessage();
            }

            // ----------- END OF CODE TO LOOP ----------- //

            // Wait at end
            WaitForKeyPress();
        }

        void Task()
        {
            // This program currently only runs once
            // We are going to modify it so that it loops back to the menu after finishing
            // The user will also have the option to exit the program from the menu
        }

        static void ExtensionTasks()
        {
            // 1. Re-create 'Distance conversion' so that it loops back to the main menu
            // 2. Re-create 'Temperature conversion' so that it loops back to the main menu
            // 3. Create an average number calculator that works with any amount of numbers
        }

        private static string RunMenuOptions()
        {
            Console.Clear();
            Console.WriteLine("Choose an Option:");
            Console.WriteLine("1. Area of Circle");
            Console.WriteLine("2. Area of Rectangle");
            Console.WriteLine("3. Area of Triangle");
            Console.WriteLine("4. Exit");
            string choice = Console.ReadLine();
            return choice;
        }

        private static void CalculateCircle()
        {
            Console.WriteLine();
            Console.Write("Radius: ");
            float radius = float.Parse(Console.ReadLine());
            Console.WriteLine("Area: " + (Math.PI * radius * radius));
        }

        private static void CalculateTriangle()
        {
            Console.WriteLine();
            Console.Write("Base: ");
            float width = float.Parse(Console.ReadLine());
            Console.Write("Height: ");
            float height = float.Parse(Console.ReadLine());
            Console.WriteLine("Area: " + (0.5 * width * height));
        }

        private static void CalculateRectangle()
        {
            Console.WriteLine();
            Console.Write("Width: ");
            float width = float.Parse(Console.ReadLine());
            Console.Write("Length: ");
            float length = float.Parse(Console.ReadLine());
            Console.WriteLine("Area: " + (width * length));
        }

        private static void WaitForKeyPress()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private static void ErrorMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Invalid Choice! Press any key to continue...");
            Console.ReadKey();
        }
    }
}
