using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 1, 2, 3, 4, 5 };

            Array.Reverse(number);

            foreach (int num in number)
            {
                Console.Write($"Number: {num}");
            }

        }
    }
}
