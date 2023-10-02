using System;
using System.Collections.Generic;

namespace ProgrammingExercisesIST
{
    class Project_30_InsultGenerator
    {
        static void Main(string[] args)
        {
            // Random number generator
            Random rnd = new Random();

            // Ask for your name
            string name = GetName();

            // Generate a random insult
            GenerateInsult(name, rnd);
        }

        // -------------------- TASKS TO DO -------------------- //

        // 1. Should return a random adjective. E.g. "a hairy" or "an untalented"
        private static string GetAdjective(Random rnd)
        {
            List<string> adjectives = new List<string>
            {
                "hairy", "untalented"
            };
            return adjectives[rnd.Next(adjectives.Count)];
        }

        // 2. Should return a random compound adjective. E.g. "no-good" or "big-headed"
        private static string GetCompoundAdjective(Random rnd)
        {
            
        }

        // 3. Should return an object. E.g. "monkey" or "nerd"
        private static string GetObject(Random rnd)
        {
            
        }

        // 4. Ask for and return the user's name
        private static string GetName()
        {
            
        }

        // -------------------- ALREADY DONE -------------------- //

        // Generate the insult. E.g. "Jeff, you are a smelly, no-good sloth"
        private static void GenerateInsult(string name, Random rnd)
        {
            Console.WriteLine("");
            Console.WriteLine(name + ", you are " + GetAdjective(rnd) + ", "
                                + GetCompoundAdjective(rnd) + " " + GetObject(rnd));
            Menu(name, rnd);
        }

        private static void Menu(string name, Random rnd)
        {
            Console.Write("Would you like another insult? y/n: ");
            if (Console.ReadLine() == "y")
            {
                GenerateInsult(name, rnd);
            }
        }        
    }
}
