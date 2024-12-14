using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        
        
        {
            String[] familyNames = new string[3];
            familyNames[0] = "Sai";
            familyNames[1] = "Sharan";
            familyNames[2] = "varun";
            // familyNames[3] = "Sangam";

            Console.WriteLine($"Family First person: {familyNames[1]}");

            familyNames[0] = "Shai";

            Console.WriteLine($"Reassigned value of index 1:{familyNames[0]}");


        }
    }
}
