using System;

namespace ProgrammingExercisesIST
{
    class Project_27_Arrays
    {
        static void Main(string[] args)
        {
            // Complete the following tasks:
            Task1();
            Task2();
            Task3();

            // Wait at End
            WaitForKeyPress("End of the program");
        }

        private static void Task1()
        {
            // 1. Create an array of 5 names


            // 2. Print out name 3 to the screen


            // 3. Ask the user to input a new name to override name 4


            // 4. Make name 1 and name 5 equal



            // End of Task 1
            WaitForKeyPress("End of Task 1");
        }

        private static void Task2()
        {
            // 1. Create an array of 5 integers


            // 2. Use a loop to input all 5 numbers


            // 3. Add 10 to item 2


            // 4. Sort the array


            // 5. Print the contents of the array to the screen



            // End of Task 2
            WaitForKeyPress("End of Task 2");
        }

        private static void Task3()
        {
            // 1. Create an array of 5 floating point numbers


            // 2. Use a loop to input all 5 numbers


            // 3. Create a float called total


            // 4. Use a loop to add all of the numbers together into total


            // 5. Print out total



            // End of Task 3
            WaitForKeyPress("End of Task 3");
        }

        static void ExtensionTasks()
        {
            // 1. Write a program to read any number (user choice) of values in an array and display it in reverse order.
            // 2. Write a program to input any number of names (user choice), sort the list, then search for the name
        }

        static void Questions()
        {
            // 1. What are arrays used for?
            // 
            // 
            // 2. Can you mix data types in an array?
            // 
            // 
            // 3. Can you easily add or remove items from an array?
            // 
            //
        }

        static void Example1_Basics()
        {
            // This is an example of creating an array of Integers and assigning the values immediately
            //
                int[] nums = new int[5] { 1, 5, 3, 8, 9 };
            //
            // Arrays start at 0, so to acess item 2:
            // The following will print "Item 2 is 5"
            //
                Console.WriteLine("Item 2 is: " + nums[1]);
            //
            // You can change the contents of an array:
            //
                nums[3] = 6;
            //
            // The following will give an error because the array is not long enough:
            //
                nums[5] = 7;
            //
            // The following will give an error because the array only accepts integers:
            //
            //  nums[2] = "Hello";
        }

        static void Example2_Loops()
        {
            // Arrays can be looped over easily for a for loop:
            // Note how we use the loop counter to access the array's index.
            //
            int[] intArray = new int[5] { 10, 20, 30, 40, 50 };
            
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }

            // Or a ForEach loop:
            // These loops are easier to read but you don't have access to the index
            //
            foreach (int item in intArray)
            {
                Console.WriteLine(item);
            }
            //
            // You can even input data into arrays using a loop:
            //
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = int.Parse(Console.ReadLine());
            }
        }

        static void Example3_Extras()
        {
            // New string array of animals
            string[] stringArray = new string[5] { "Snake", "Dog", "Bird", "Mouse", "Cat" };            

            // Loop through to see array contents
            Console.WriteLine("Before sorting: ");
            foreach (string item in stringArray)            
                Console.WriteLine(item);

            // Sort the array
            Console.WriteLine("---------------------");
            Array.Sort(stringArray);

            // Loop through again to see it sorted
            Console.WriteLine("After sorting: ");
            foreach (string item in stringArray)
                Console.WriteLine(item);

            // Search for an item in the array
            Console.WriteLine("---------------------");
            string animal = "Cat";
            int foundAtIndex = Array.BinarySearch(stringArray, animal);
            Console.WriteLine("Animal was found at position: " + foundAtIndex);

            // Resize the array to a length of 10
            Console.WriteLine("---------------------");
            Array.Resize(ref stringArray, 10);

            // Loop through again to see it resized
            Console.WriteLine("After resizing: ");
            foreach (string item in stringArray)
                Console.WriteLine(item);

            // Reverse the array
            Console.WriteLine("---------------------");
            Array.Reverse(stringArray);

            // Loop through again to see it reversed
            Console.WriteLine("After reversing: ");
            foreach (string item in stringArray)
                Console.WriteLine(item);
        }

        static void Links()
        {
            // https://www.tutorialspoint.com/csharp/csharp_arrays.htm
            // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/
        }

        private static void WaitForKeyPress(string message)
        {
            Console.WriteLine();
            Console.WriteLine(message);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
