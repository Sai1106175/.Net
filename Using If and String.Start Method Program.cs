using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        
        
        {
            String[] OrderID = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

            

            foreach (string newOrderDetails in OrderID)
            {
                if (newOrderDetails.StartsWith('B')) // string.StartsWith is a method used to identify the first charater is matching with the given data.

                {
                    Console.WriteLine(newOrderDetails);
                }
            }

    

        }
    }
}
