using System;

namespace _24_Pyramid
{
    class Pyramid
    {
        static void Main(string[] args)
        {
            // Get the height
            int height = GetNumber("Enter a height for the pyramid");

            // 1. Create the outer loop. This should loop 'height' times
            // 2. Create an inner loop for printing spaces
            // 3. Create an inner loop for printing *



            // Wait at end
            WaitForKeyPress();
        }

        void EaserTask()
        {
            // Use nested loops to print the following shape.
            // The user should be able to choose the height.
            // 
            //      *
            //     **
            //    ***
            //   ****
            //  *****
        }

        void HarderTask()
        {
            // Use nested loops to print the following shape.
            // The user should be able to choose the height.
            // This task may require a third inner loop.
            // 
            //      **
            //     ****
            //    ******
            //   ********
            //  **********
        }

        // This is an example of using loops to ensure that the input is correct
        static int GetNumber(string message)
        {
            bool success;
            int number;
            do
            {
                Console.WriteLine(message);
                success = int.TryParse(Console.ReadLine(), out number);
            } while (!success);
            return number;
        }

        private static void WaitForKeyPress()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
