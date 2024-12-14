using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        
        
        {


            int[] inventory = { 200, 450, 700, 175, 250 };
            int sum = 0;
            
            foreach (int totalInventory in inventory)
            {
                sum += totalInventory;
            }


            int value = 0;

            foreach (int binvalue in inventory)
            {
                value++;


                Console.WriteLine($"Bin {value} = B{binvalue} items (Running Total: {binvalue} "); 
            }

            Console.WriteLine($"Total Inventorry: {sum}");






        }
    }
}
