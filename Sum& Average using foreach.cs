using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)

        //Problem: Write a program that takes an array of integers and calculates the sum and average of its elements using a foreach loop.
        //        Input: [10, 20, 30, 40, 50]


        {
            int[] givenData = { 10, 20, 30, 40, 50 };

            int indexofGivedata = givenData.Length;

            int Sum = 0;

            foreach (int sumofGivenData in givenData)
            {
                Sum += sumofGivenData;

            }

            Console.WriteLine($"The Sum of given Data{Sum} ");

            decimal average;

            average = Sum / indexofGivedata;

            Console.WriteLine($"Average of given data {average}");


        }
    }
}
