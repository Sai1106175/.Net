using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            // Prompt the user for input
            Console.Write("Enter a positive integer (N): ");
            N = Convert.ToInt32(Console.ReadLine());

            // Check for invalid input
            if (N < 1)
            {
                Console.WriteLine("Please enter a positive integer greater than 0.");
            }
            else
            {
                Console.WriteLine($"Even numbers from 1 to {N}:");

                // Use a for loop to find even numbers
                for (int i = 1; i <= N; i++)
                {
                    if (i % 2 == 0)  // Check if the number is even
                    {
                        Console.Write(i + " ");  // Print the even number
                    }
                }
            }

        }
    }
}
