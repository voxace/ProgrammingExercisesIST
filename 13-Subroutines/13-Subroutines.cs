using System;

namespace ProgrammingExercisesIST
{
    class Project_13_Subroutines
    {
        static void Main(string[] args)
        {
            // 1. Create a subroutine called "SayHello" to print the message "Hello World"


            // The "Wait" subroutine is called here
            Wait();

        }

        static void Wait()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void Questions()
        {
            // 1. What is a subroutine?
            // 
            // 
            // 2. What does the 'void' keyword mean?
            // 
            // 
            // 3. What does it mean to 'call' a subroutine?
            // 
            //
        }

        static void ExtensionTasks()
        {
            // 1. Try creating extra subroutines that do whatever you like
            // 2. Try calling the subroutines multiple times
            // 3. Try calling one subroutine from within another
        }

        static void Links()
        {
            // https://www.tutorialspoint.com/csharp/csharp_methods.htm
            // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods
        }
    }
}


/* ------------------------------------------------------------------------------------------ /

NOTE:

Now that we have learnt about subroutines, I have embedded the questions, extensions tasks and so on into 'fake' subrooutines.
This will be the last comment section at the bottom you see. Don't forget to submit your work at Peergrade for each future program!


WHEN FINISHED:

1. Click the Save All button
2. Go to http://www.peergrade.io to submit this Program.cs file
3. Give feedback to two of your classmates, and review the feedback you have received
4. If the feedback suggests that there is room for improvement, you may come back and modify your code / answers
   
/ ------------------------------------------------------------------------------------------ */
