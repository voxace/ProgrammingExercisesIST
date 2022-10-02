using System;

namespace ProgrammingExercisesIST
{
    class Project_04_MoreVariables
    {
        static void Main(string[] args)
        {
            //  1. This program has 3 errors that you can fix by creating some variables.
            //     Create the correct variables using 3 different data types so that the WriteLine statement outputs:
            //     "As of 2016 the population of China was 1.379 billion."




            
            // Do not modify these lines:

            Console.WriteLine($"As of {year} the population of {country} was {population} billion.");
            Console.ReadLine();
        }

        static void Questions()
        {
            /* 1. Why were the words "year", "country" and "population" originally underlined?
             * 
             * 
             * 
             * 2. What is the purpose of the dollar sign ($) before the double quotes in the final message? 
             * 
             * 
             * 
             */
        }

        static void ExtensionTasks()
        {
            // 1. Print out another statement using a three or more new variables of different data types
            // 2. Find out how to include "double quotes" in a string using an "escape character"
            // 3. Find out how to round down or change the display format of a number using ".ToString()"
        }

        static void Example()
        {
            // This is an example of creating a double precision floating point number and outputting it to the console
            double preciseNumber = 2.997;
            Console.WriteLine("My precise number is: " + preciseNumber);
            Console.ReadLine();
        }

        static void Links()
        {
            // String Interpolation: https://www.w3schools.com/cs/cs_strings_interpol.php
            // Escape and Special Characters: https://www.w3schools.com/cs/cs_strings_chars.php
            // Formatting Strings: https://learn.microsoft.com/en-us/dotnet/standard/base-types/formatting-types
            // Standard Numeric Formats: https://learn.microsoft.com/en-us/dotnet/standard/base-types/formatting-types
        }
    }
}
