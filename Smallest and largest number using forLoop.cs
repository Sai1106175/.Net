using System;

class LargestAndSmallest
{
    static void Main()
    {
        Console.WriteLine("Please enter the number range till where you wanted to compair");
        int N = Convert.ToInt32(Console.ReadLine());

        if (N < 0)
        {
            Console.WriteLine("Please enter the positive Number");
            return;
        }

        int[] listofnumbers = new int[N];

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine($"Please enter {i + 1}: ");
            listofnumbers[i] =Convert.ToInt32( Console.ReadLine());
            
        }

        int smallestNumber = listofnumbers[0];
        int largestNumber = listofnumbers[0];

        for (int i = 0; i < N; i++)
        {

            if (listofnumbers[i] < smallestNumber)
                smallestNumber = listofnumbers[i];

            if (listofnumbers[i] > largestNumber)
                largestNumber = listofnumbers[i];

        }

        Console.WriteLine($"Smallest number: {smallestNumber} Largest Number:{largestNumber}");
    }
}
