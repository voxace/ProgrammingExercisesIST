using System;

namespace ProgrammingExercisesIST
{
    class Project_15_Functions
    {
        static void Main(string[] args)
        {
            // Input two numbers
            Console.Write("Enter number 1: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter number 2: ");
            int y = int.Parse(Console.ReadLine());

            // EXAMPLE: Use the function "AddNumbers" and print the result
            int additionResult = AddNumbers(x, y);
            Console.WriteLine($"{x} plus {y} equals {additionResult}");

            // EXAMPLE 2: Using "AddNumbers" with the numbers 3 and 7 instead of the inputs
            int additionResult2 = AddNumbers(3, 7);
            Console.WriteLine($"3 plus 7 equals {additionResult2}");

            // 1. Create a function called MultiplyNumbers that takes two integers, multiplies them and returns the result
            // 2. Create a variable called "multiplicationResult" of type 'int' and assign it the result of the MultiplyNumbers function using 7 and 5


            // 3. Output the result of the multiplication below. E.g. 7 times 5 = 35


            // 4. Output the result of the MultiplyNumbers function using x and y with only one line of code


            // The "Wait" subroutine is called here
            Wait();
        }

        // This functions takes two numbers, adds them and returns the answer
        private static int AddNumbers(int num1, int num2)
        {
            return num1 + num2;
        }

        private static void Wait()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void Questions()
        {
            // 1. What is a function?
            // 
            // 
            // 2. What does a function do that a subroutine does not?
            // 
            // 
        }

        static void ExtensionTasks()
        {
            // 1. Try creating extra functions with parameters that do whatever you like
            // 2. Experiment with different data types for the parameters and return types
            // 3. Are there any further ways to abstract away the details of this program (e.g. InputAndAddTwoNumbers)?
        }

        static void Links()
        {
            // https://www.tutorialspoint.com/csharp/csharp_methods.htm
            // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods
        }
    }
}
