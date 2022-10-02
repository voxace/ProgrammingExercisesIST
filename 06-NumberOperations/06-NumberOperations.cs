using System;

namespace ProgrammingExercisesIST
{
    class Project_06_NumberOperations
    {
        static void Main(string[] args)
        {
            // This is how we can store user input as a floating point number
            
            Console.WriteLine("Please enter a number for X:");
            double x = Convert.ToDouble(Console.ReadLine());

            // 1. Now do the same for the variable 'y'




            // We can then perform some mathematical operations on it. E.g. addition with +

            Console.WriteLine("X plus Y = " + (x + y));

            // 2. Try doing multiplication with * 



            // 3. Subtraction with - 



            // 4. Division with /



            // 5. Wait for input before ending


        }

        static void Questions()
        {
            /* 1. What does "Convert.ToSingle" do?
             * 
             * 
             * 
             * 2. What is a parameter? Give an example of where you have used one.
             * 
             * 
             * 
             * 3. Why is the 'Console.ReadLine()' a parameter to Convert.ToSingle()?
             * 
             * 
             * 
             */
        }

        static void ExtensionTasks()
        {
            // 1. Modify the program to work with the 'double' type.
            // 2. Research how to get the remainder of a division using the 'modulus operator'.
        }

        static void Example()
        {
            /* This is what the final program output might look like:
             * 
             * Please enter a number for X:
             * 7
             * Please enter a number for Y:
             * 3
             * X plus Y = 10
             * X times Y = 21
             * X minus Y = 4
             * X divided by Y = 2.333333
             */
        }

        static void Links()
        {
            // Convert.ToSingle: https://www.tutorialspoint.com/convert-tosingle-method-in-chash
            // Parameters: https://www.w3schools.com/cs/cs_method_parameters.php
        }
    }
}