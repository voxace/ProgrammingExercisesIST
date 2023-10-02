using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_Testing
{
    internal class Program
    {
        // GOAL: To learn about FOR loops

        static void Main(string[] args)
        {
            for (int count = 10; count > 0; count--)
            {
                Console.WriteLine(count);
            }

            // Wait for input before ending
            Console.ReadLine();
        }
    }
}
