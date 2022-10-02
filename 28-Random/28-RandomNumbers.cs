using System;

namespace ProgrammingExercisesIST
{
    class Project_28_RandomNumbers
    {
        static void Main(string[] args)
        {
            // Task: create a program that asks if you would like to roll one or two dice
            // It will use 'Random' to simulate the dice rolls. It will print what each dice rolled
            // It will also print the total and ask if you would like to roll again



        }

        static void ExtensionTasks()
        {
            // 1. Practice you knowledge of loops and arrays to keep a list of each total rolled
        }

        static void Example()
        {
            // This is an example of creating random number generator
            //
            System.Random rnd = new System.Random();
            //
            // Then using it to create two random numbers between 1 and 10
            //
            int num1 = rnd.Next(1, 11);
            int num2 = rnd.Next(1, 11);
        }
    }
}
