using System;

namespace ProgrammingExercisesIST
{
    class Project_12_BetterAreaCalculator
    {
        static void Main(string[] args)
        {
            // The code is starting to get longer and more difficult to read
            // Here we are going to learn how to 'refactor code' into chunks called methods
            // I have already extracted the code for the menu and circles into methods

            ShowMenu();
            string choice = Console.ReadLine();
            Console.WriteLine();            

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
            else if(choice == "4")
            {
                CalculateTrapezium();
            }
            else
            {
                Console.WriteLine("Invalid Choice!");
            }

            // Wait
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private static void CalculateTrapezium()
        {
            Console.WriteLine("Coming soon!");
        }

        private static void CalculateRectangle()
        {
            // TASK 1:
            // Highlight the code for calculating the rectangle
            // Right click and then choose "Quick actions and Refactorings"
            // Then choose "Extract Method"
            // Give it the name: "CalculateRectangle" (no spaces allowed)
            Console.Write("Width: ");
            float width = float.Parse(Console.ReadLine());
            Console.Write("Length: ");
            float length = float.Parse(Console.ReadLine());
            Console.WriteLine("Area: " + (width * length));
        }

        private static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an Option:");
            Console.WriteLine("1. Area of Circle");
            Console.WriteLine("2. Area of Rectangle");
            Console.WriteLine("3. Area of Triangle");
        }

        private static void CalculateCircle()
        {
            Console.Write("Radius: ");
            float radius = float.Parse(Console.ReadLine());
            Console.WriteLine("Area: " + (Math.PI * Math.Pow(radius,2)));
        }

        private static void CalculateTriangle()
        {
            // TASK 2:
            // I have already created a method below called "CalculateTriangle"
            // Instead of using the quick actions as above, try cutting and pasting the code below into it
            // You will then have to write "CalculateTriangle();" here to 'call' it
            Console.Write("Base: ");
            float width = float.Parse(Console.ReadLine());
            Console.Write("Height: ");
            float height = float.Parse(Console.ReadLine());
            Console.WriteLine("Area: " + (0.5 * width * height));
        }

        static void Questions()
        {
            /* 1. What is the purpose of splitting the code into smaller chunks (methods)?
             * 
             * 
             * 
             * 2. Why is it important to give a warning message to the user in the else statement?
             * 
             * 
             * 
             */
        }

        static void ExtensionTasks()
        {
            // 1. Add a trapezium option to the program. It should also be a separate method.
        }

        static void Example()
        {
            /* This is an example of the program's output:
             * 
             * Choose an Option:
             * 1. Area of Circle
             * 2. Area of Rectangle
             * 3. Area of Triangle
             * 
             * 2
             * 
             * Enter Width: 3
             * Enter Height: 4
             * 
             * The area of the rectangle is 12
             * 
             * "Press any key to continue...
             */
        }

        static void Links()
        {
            // Methods: https://www.w3schools.com/cs/cs_methods.php
        }
    }
}
