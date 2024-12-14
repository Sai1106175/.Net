using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        
        
        {
            string[] familynames = new string[3];
            familynames[0] = "sai";
            familynames[1] = "sharan";
            familynames[2] = "varun";
            //familynames[3] = "sangam";

            Console.WriteLine($"family first person: {familynames[1]}");

            familynames[0] = "shai";

            Console.WriteLine($"reassigned value of index 1:{familynames[0]}");

            Console.WriteLine($"Length of the Array: {familynames.Length}"); // using lenth property you can find the length of the array if the array index is unknown.






        }
    }
}
