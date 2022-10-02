using System;

namespace ProgrammingExercisesIST
{
    class Project_08_Selection
    {
        static void Main(string[] args)
        {
            // Variables and Input
            Console.Write("Please enter a mark out of 100: ");
            int mark = int.Parse(Console.ReadLine());

            // 1. Make the program print out:
            // "Pass" if the mark is 50 or above
            // "Fail" if the mark is less than 50
            if(mark < 50)
            {
                
            }
            else
            {

            }

            // Wait for input before ending
            Console.ReadLine();
        }

        static void Questions()
        {
            /* 1. What does the < symbol mean?
             * 
             * 
             * 
             * 2. What does selection mean?
             * 
             * 
             * 
             * 3. Which part executes if the condition is false (the 'if' part or 'else' part)?
             * 
             * 
             * 
             */
        }

        static void ExtensionTasks()
        {
            // 1. Try using a float or double instead of an integer.
            // 2. Research online to find out how to use an "else if" statement.
            //    Use this information to print out grades for different mark levels. E.g. A, B, C, D
        }

        static void Example()
        {
            //This is an example of using selection:

            string name = "Jeff";
            if (name == "Jeff")
            {
                Console.WriteLine("My name is Jeff!");
            }
            else
            {
                Console.WriteLine("My name is NOT Jeff!!!");
            }
        }

        static void Links()
        {
            // Selection: https://www.tutorialspoint.com/csharp/csharp_decision_making.htm
            // Selection: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/if-else
        }
    }
}