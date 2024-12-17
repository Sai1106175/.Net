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
            int number;
            long factorial = 1; // Using long to handle large factorial values
            int i = 1;

            // Prompt the user for input
            Console.Write("Enter a positive number to calculate its factorial: ");
            number = Convert.ToInt32(Console.ReadLine());

            // Check if the input is valid
            if (number < 0)
            {
                Console.WriteLine("Factorial is not defined for negative numbers.");
            }
            else
            {
                // Use do-while loop to calculate the factorial
                do
                {
                    factorial *= i;
                    i++;
                } while (i <= number);

                // Output the result
                Console.WriteLine($"The factorial of {number} is {factorial}.");
            }


            }
        }
}
