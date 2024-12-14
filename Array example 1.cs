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
            // familyNames[3] = "Sangam"; // If we are defining the list of arrays more then the mentioned index value - then you will be pooped up with an error index value out of range.

            Console.WriteLine($"Family First person: {familyNames[1]}");



        }
    }
}
