using System;

namespace ProgrammingExercisesIST
{
    class Project_11_AreaCalculator
    {
        static void Main(string[] args)
        {
            // Menu
            Console.WriteLine("Choose an Option:");
            Console.WriteLine("1. Area of Circle");
            Console.WriteLine("2. Area of Rectangle");
            Console.WriteLine("3. Area of Triangle");
            string choice = Console.ReadLine();
            
            // Area of Circle
            if (choice == "1")
            {
                Console.WriteLine();
                Console.Write("Radius: ");
                float radius = float.Parse(Console.ReadLine());
                Console.WriteLine("Area: " + (Math.PI * radius * radius));
            }

            // 1. Area of rectangle




            // 2. Area of triangle




            // 3. Invalid input




            // Wait
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}

/* ------------------------------------------------------------------------------------------ /

TASK:

Finish off the program so that it also calculates the area of rectangles and triangles.
It should also handle an invalid menu choice with a warning message.


EXTENSION TASKS:

1. Add a trapezium to the menu



EXAMPLE:

This is an example of the program's output:
 
  Choose an Option:
  1. Area of Circle
  2. Area of Rectangle
  3. Area of Triangle
  
  2
   
  Enter Width: 3
  Enter Height: 4
  
  The area of the rectangle is 12
  
  "Press any key to continue...



WHEN FINISHED:

1. Click the Save All button
2. Go to http://www.peergrade.io to submit this Program.cs file
3. Give feedback to two of your classmates, and review the feedback you have received
4. If the feedback suggests that there is room for improvement, you may come back and modify your code / answers
   
/ ------------------------------------------------------------------------------------------ */