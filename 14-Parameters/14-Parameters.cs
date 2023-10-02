using System;

namespace ProgrammingExercisesIST
{
    class Project_14_Parameters
    {
        static void Main(string[] args)
        {
            // 1. Create a method called "SayHello" to print the message "Hello (name)"
            SayHello("David", 37);
            SayHello("James", 45);

            // Example: The following method takes two integers, adds them and prints the result.
            AddNumbers(3, 7);

            // 2. Create a method called "SubtractNumbers" that takes two integers, subtracts one and prints the result


            // The "Wait" method is called here. Notice it takes a colour as a parameter.
            Wait(ConsoleColor.Blue);
        }

        private static void SayHello(string name, int age)
        {
            Console.WriteLine($"Hello {name}, you are {age} years old!");
        }

        private static void AddNumbers(int num1, int num2)
        {
            int answer = num1 + num2;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine($"{num1} + {num2} equals {answer}");
        }

        private static void Wait(ConsoleColor textColor)
        {
            Console.ForegroundColor = textColor;
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void Questions()
        {
            /* 1. What is a parameter?
             * 
             * 
             * 
             * 2. When writing a method, what two things do you need to supply to create a parameter for it?
             *    E.g. static void MyMethod(firstThing secondThing)
             * 
             * 
             * 
             */
        }

        static void ExtensionTasks()
        {
            // 1. Try creating extra methods with parameters that do whatever you like
            // 3. Experiment with multiple parameters and different data types for the parameters
        }

        static void Links()
        {
            // https://www.tutorialspoint.com/csharp/csharp_value_parameters.htm
            // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/passing-parameters
        }
    }
}
