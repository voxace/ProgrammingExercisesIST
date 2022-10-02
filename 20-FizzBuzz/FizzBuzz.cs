using System;

namespace ProgrammingExercisesIST
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            // 1. Implement "Fizz Buzz" as outlined below:


            // Wait at end
            WaitAtEnd();
        }

        void Task()
        {
            // Write a program that prints the integers from 1 to 100, but:
            // - For multiples of three, print “Fizz”  (instead of the number)
            // - For multiples of five, print “Buzz”  (instead of the number)
            // - For multiples of both three and five, print “FizzBuzz”  (instead of the number)
        }

        private static void WaitAtEnd()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
