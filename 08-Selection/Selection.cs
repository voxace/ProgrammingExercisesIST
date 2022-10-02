using System;

namespace ProgrammingExercisesIST
{
    class Selection
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
    }
}


/* ------------------------------------------------------------------------------------------ /

EXTENSION TASKS:

1. Try using a float instead of an integer.
2. Research online to find out how to use an "else if" statement.
   Use this information to print out grades for different mark levels. E.g. A, B, C, D


QUESTIONS:
        
1. What does the < symbol mean?




2. What does selection mean?




3. Which part executes if the condition is false (the 'if' part or 'else' part)?




EXAMPLE:

This is an example of using selection:

  string name = "Jeff";
  if (name == "Jeff")
  {
      Console.WriteLine("My name is Jeff!");
  }
  else
  {
      Console.WriteLine("My name is NOT Jeff!!!");
  }



LINKS:
https://www.tutorialspoint.com/csharp/csharp_decision_making.htm
https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/if-else


WHEN FINISHED:

1. Click the Save All button
2. Go to http://www.peergrade.io to submit this Program.cs file
3. Give feedback to two of your classmates, and review the feedback you have received
4. If the feedback suggests that there is room for improvement, you may come back and modify your code / answers
   
/ ------------------------------------------------------------------------------------------ */