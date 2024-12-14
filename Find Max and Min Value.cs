
        //Problem: Write a program to find the maximum and minimum numbers in an array using a foreach loop.
        //[5, 10, 15, 2, 8, 22]

        
            int[] numbers = { 5, 10, 15, 2, 8, 22 };

            int max = int.MinValue;
            int min = int.MaxValue;

            foreach (int number in numbers)
            {
                // Update max if the current number is greater
                if (number > max)
                {
                    max = number;
                }

                // Update min if the current number is smaller
                if (number < min)
                {
                    min = number;
                }
            }






        }
    }
}
