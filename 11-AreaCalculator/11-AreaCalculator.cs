using System;

namespace ProgrammingExercisesIST
{
    class Project_11_AreaCalculator
    {
        static void Main(string[] args)
        {
            // TASK:
            // Finish off the program so that it also calculates the area of rectangles and triangles.
            // It should also handle an invalid menu choice with a warning message.

            // Menu
            Console.WriteLine("Choose an Option:");
            Console.WriteLine("1. Area of Circle");
            Console.WriteLine("2. Area of Rectangle");
            Console.WriteLine("3. Area of Triangle");
            string choice = Console.ReadLine();
            Console.WriteLine();

            // Area of Circle
            if (choice == "1")
            {
                Console.Write("Radius: ");
                float radius = float.Parse(Console.ReadLine());
                Console.WriteLine("Area: " + (Math.PI * Math.Pow(radius,2)));
            }

            // 1. Area of rectangle




            // 2. Area of triangle




            // 3. Invalid input




            // Wait
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void Questions()
        {
            /* 1. What is the difference between Console.Write()? and Console.WriteLine()?
             * 
             * 
             * 
             * 2. What is the difference between Console.Write()? and Console.WriteLine()?
             * 
             * 
             * 
             */
        }

        static void ExtensionTasks()
        {
            // 1. Add a trapezium to the menu
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
            // Math: https://www.ictdemy.com/csharp/basics/mathematical-functions-in-csharp-net-math-library
        }
    }
}