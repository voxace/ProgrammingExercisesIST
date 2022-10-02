using System;

namespace ProgrammingExercisesIST
{
    class NestedLoops
    {
        static void Main(string[] args)
        {
            // 1. Run the program and see how this example works
            // When you are done comment it out and do task 2
            CubedNumbers(2,10);

            // 2. Create a nested FOR loops structure that prints out the 12 times tables
            //  - Don't forget to use different variables (e.g. i and j) for the counters
            //  - Try to format it nicely using a combination of 'Write' and 'WriteLine'


            // Wait at end
            WaitForKeyPress();
        }

        // Below is a silly example of how to calculate squares and cubes of a range of numbers
        // It does illustrate that you can 'nest' loops within each other
        // The inner loop will run all the way through every time the middle loop iterates
        // The middle loop will run all the way through every time the outer loop iterates
        // The outer loops only runs through from min to max once
        static void CubedNumbers(int min, int max)
        {
            for (int i = min; i <= max; i++) // Outer loop
            {
                for (int j = min; j <= max; j++) // Middle Loop
                {
                    for (int k = min; k <= max; k++) // Inner Loop
                    {
                        // Checks to see if i, j and k are equal. E.g. 3,3,3
                        if(i == j && j == k)
                        {
                            // Prints out i*j*k. E.g. 3*3*3 = 27
                            Console.WriteLine($"{i} cubed equals {i * j * k}"); // Cubed
                        }
                    }
                }
                Console.WriteLine("-------------------"); // Seperator
            }
            Console.ReadKey();
        }

        private static void WaitForKeyPress()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
