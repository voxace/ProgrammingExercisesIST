using System;

namespace _25_GuessMyNumber
{
    class GuessMyNumber
    {
        static void Main(string[] args)
        {
            // Generate Random Number from 1 to 100
            Random rnd = new System.Random();
            int randomNumber = rnd.Next(1, 101);

            // Set guess to number out of random range
            int guess = -1;

            // 1. Create a loop that only runs if the guess is wrong
            // 2. Inside the loop ask the user to guess a number
            // 3. After taking the input, check to see if it is too high, too low or correct




        }

        static void ExtensionTasks()
        {
            // 1. Get the random range from the user
            // 2. Count how many tries it took
            // 3. Put the whole game in a loop so that you can play again
        }
    }
}
