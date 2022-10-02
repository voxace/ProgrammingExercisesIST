using System;

namespace ProgrammingExercisesIST
{
    class NumberOperations2
    {
        static void Main(string[] args)
        {
            // Input X
            Console.WriteLine("Please enter a number for X:");
            double x = Convert.ToDouble(Console.ReadLine());

            // Input Y
            Console.WriteLine("Please enter a number for Y:");
            double y = Convert.ToDouble(Console.ReadLine());

            // 1. Ask the user which mathematical operation they would like to do


            // 2. Store the choice in a string variable


            // 3. Use selection (if...else if...else) to print the correct operation


            // Wait for any key before exiting
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void Questions()
        {
            /* 1. What is the difference between Console.ReadLine()? and Console.ReadKey()?
             * 
             * 
             * 
             * 
             * 2. Why do we store the choice as a string (instead of an integer)?
             * 
             * 
             * 
             */
        }

        static void ExtensionTasks()
        {
            // 1. Research online to find out how to do exponents. E.g X to the power of Y
            // 2. Research online to find out how to use the 'ToString()' function to round the answer to two decimal places.
        }

        static void Example()
        {
            /* This is an example of the program's output:
             * 
             * Please enter a number for X:
             * 7
             * Please enter a number for Y:
             * 3
             * 
             * What would you like to do:
             * 1. Addition
             * 2. Subtraction
             * 3. Multiplication
             * 4. Division 
             * 
             * 1 
             * 
             * The answer is: 10
             * 
             * Press any key to continue...
             */
        }

        static void Links()
        {
            // Selection: https://www.tutorialspoint.com/csharp/csharp_decision_making.htm
            // Selection: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/if-else
            // Console.ReadKey: https://www.dotnetperls.com/console-readkey
            // Math: https://www.ictdemy.com/csharp/basics/mathematical-functions-in-csharp-net-math-library
        }
    }
 }