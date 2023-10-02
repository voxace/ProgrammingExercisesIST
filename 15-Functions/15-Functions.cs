using System;

namespace ProgrammingExercisesIST
{
    class Project_15_Functions
    {
        static void Main(string[] args)
        {
            // Input two numbers
            int x = GetNumber();
            int y = GetNumber();

            // 1. Create a function called MultiplyNumbers that takes two integers, multiplies them and returns the result
            // 2. Create a variable called "multiplicationResult" of type 'int' and assign it the result of the MultiplyNumbers, passing in x and y
            // 3. Finally, output "multiplicationResult" using Console.WriteLine

            int result = MultiplyNumbers(x, y);

            // 4. Output the result of the MultiplyNumbers function directly in a Console.WriteLine, using any numbers as the parameters



            // "Wait" method is called here
            Wait();
        }

        private static int MultiplyNumbers(int x, int y)
        {
            int answer = x * y;
            return answer;
        }




        // Create your function "MultiplyNumbers" for task 1 here:


        // This is a function I have written to get a number from the user
        private static int GetNumber()
        {
            Console.Write("Enter number: ");
            return int.Parse(Console.ReadLine());
        }

        private static double GetDouble()
        {
            Console.Write("Enter decimal number: ");
            return int.Parse(Console.ReadLine());
        }

        // This is a method used to wait for any key to be pressed
        private static void Wait()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void Examples()
        {
            // Two numbers to use
            int x = 9;
            int y = 6;

            // EXAMPLE: Use the function "AddNumbers" and print the result
            int additionResult = AddNumbers(x, y);
            Console.WriteLine($"{x} plus {y} equals {additionResult}");

            // EXAMPLE 2: Using "AddNumbers" directly in a Console.WriteLine, with the numbers 3 and 7
            Console.WriteLine($"3 plus 7 equals {AddNumbers(3, 7)}");
        }

        // EXAMPLE FUNCTION: This functions takes two numbers, adds them and returns the answer
        private static int AddNumbers(int num1, int num2)
        {
            return num1 + num2;
        }

        static void Questions()
        {
            /* 1. What is a function?
             * 
             * 
             * 
             * 2. What does a function do that a method does not?
             * 
             * 
             * 
             */
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
