using System;

namespace _26_RockPaperScissors
{
    class RockPaperScissors
    {
        // Global variables
        static int userScore = 0;
        static int computerScore = 0;
        static bool repeat = true;
        static string result = "";

        static void Main(string[] args)
        {
            // This is the game loop
            // It consists of a set of distinct tasks
            // Your task is to use the available functions to make the game work
            while (repeat == true)
            {
                // 1. Print scores at top of screen

                // 2. User's turn, store what they picked in a string

                // 3. Computer's turn, store what they picked in a string

                // 4. Determine the winner, store user's result in a string

                // 5. Print out your result and what each player picked

                // 6. Update the score

                // 7. Ask to play again

            }
        }

        // Prints the user's and computer's scores
        void PrintScore()
        {
            Console.Clear();
            Console.WriteLine("User: " + userScore + "     Computer: " + computerScore);
        }

        // Asks the user what they would like to pick
        // Returns "Rock", "Paper" or "Scissors"
        string UserTurn()
        {
            string choice = "";
            while (choice != "1" && choice != "2" && choice != "3")
            {
                Console.WriteLine("1: Rock");
                Console.WriteLine("2: Paper");
                Console.WriteLine("3: Scissors");
                Console.Write("Your Choice: ");
                choice = Console.ReadLine();
            }

            if (choice == "1")
            {
                return "Rock";
            }
            else if (choice == "2")
            {
                return "Paper";
            }
            else
            {
                return "Scissors";
            }
        }

        // Randomly picks for the computer
        // Returns "Rock", "Paper" or "Scissors"
        string ComputerTurn()
        {
            Random rnd = new Random();
            int choice = rnd.Next(1, 4);

            if (choice == 1)
            {
                return "Rock";
            }
            else if (choice == 2)
            {
                return "Paper";
            }
            else
            {
                return "Scissors";
            }
        }

        // Determines if the user won, lost or drew the round
        // Takes two parameters: 
        // - userChoice should be "Rock", "Paper" or "Scissors"
        // - computerChoice should be "Rock", "Paper" or "Scissors"
        // Returns "Win", "Loss" or "Draw"
        string DetermineWinner(string userChoice, string computerChoice)
        {
            if (userChoice == "Rock")
            {
                if (computerChoice == "Rock")
                {
                    return "Draw";
                }
                else if (computerChoice == "Paper")
                {
                    return "Lose";
                }
                else
                {
                    return "Win";
                }
            }
            else if (userChoice == "Paper")
            {
                if (computerChoice == "Rock")
                {
                    return "Win";
                }
                else if (computerChoice == "Paper")
                {
                    return "Draw";
                }
                else
                {
                    return "Lose";
                }
            }
            else
            {
                if (computerChoice == "Rock")
                {
                    return "Lose";
                }
                else if (computerChoice == "Paper")
                {
                    return "Win";
                }
                else
                {
                    return "Draw";
                }
            }
        }

        // Prints out your result and what each player picked
        // Takes three parameters: 
        // - result should be "Win", "Loss" or "Draw"
        // - userChoice should be "Rock", "Paper" or "Scissors"
        // - computerChoice should be "Rock", "Paper" or "Scissors"
        void GiveFeedback(string result, string userChoice, string computerChoice)
        {
            Console.WriteLine();
            Console.WriteLine(result + "! The computer chose " + computerChoice + " and you chose " + userChoice);
        }

        // Asks if the user would like to play again
        // Returns true if they would, false if they don't
        bool PlayAgain()
        {
            Console.WriteLine();
            string choice = "";
            while (choice != "1" && choice != "2")
            {
                Console.WriteLine("Play again? 1 = Yes, 2 = No");
                choice = Console.ReadLine();
            }
            if (choice == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Updates the score
        // result should be "Win", "Loss" or "Draw"
        // Awards the player a point for a win, awards the computer a point if they lose
        void UpdateScores(string result)
        {
            if (result == "Win")
            {
                userScore++;
            }
            else if (result == "Lose")
            {
                computerScore++;
            }
        }
    }
}
