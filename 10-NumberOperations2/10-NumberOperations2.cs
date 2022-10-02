using System;

namespace ProgrammingExercisesIST
{
    class NumberOperations2
    {
        static void Main(string[] args)
        {
            // Input X
            Console.WriteLine("Please enter a number for X:");
            double x = double.Parse(Console.ReadLine());

            // Input Y
            Console.WriteLine("Please enter a number for Y:");
            double y = double.Parse(Console.ReadLine());

            // 1. Ask the user which mathematical operation they would like to do


            // 2. Store the choice in a string variable


            // 3. Use selection (if...else if...else) to print the correct operation


            // Wait for any key before exiting
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
 }


/* ------------------------------------------------------------------------------------------ /

EXTENSION TASKS:

1. Research online to find out how to do powers. E.g X to the power of Y
2. Research online to find out how to use the 'ToString()' function to round the answer to two decimal places.


QUESTIONS:
        
1. What is the difference between Console.ReadLine()? and Console.ReadKey()?




2. Why do we store the choice as a string?





EXAMPLE:

This is an example of the program's output:

  Please enter a number for X:
  7
  Please enter a number for Y:
  3
  
  What would you like to do:
  1. Addition
  2. Subtraction
  3. Multiplication
  4. Division
   
  1
  
  The answer is: 10
  
  Press any key to continue...



WHEN FINISHED:

1. Click the Save All button
2. Go to http://www.peergrade.io to submit this Program.cs file
3. Give feedback to two of your classmates, and review the feedback you have received
4. If the feedback suggests that there is room for improvement, you may come back and modify your code / answers
   
/ ------------------------------------------------------------------------------------------ */