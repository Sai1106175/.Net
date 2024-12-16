using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int TotalCoffeeBill = 0;
            Console.WriteLine("Welcome to the coffee world");
            start:
            Console.WriteLine("Please select from the below list - \n 1 - Small Coffee (1 Dollor) \n 2- Medium Coffee (2Dollors) \n 3- Large Coffee (3 Dollors)");
            int Userinput = int.Parse (Console.ReadLine());

            switch (Userinput)
            {
                case 1:
                    TotalCoffeeBill += 1;
                    break;

                case 2:
                    TotalCoffeeBill += 2;
                    break;

                case 3:
                    TotalCoffeeBill += 3;
                    break;

                default:
                    Console.WriteLine("Entered Input {0} is invalid, Please enter the valid input.. Thankyou!!", Userinput);
                    goto start;
            }
            decision:
            Console.WriteLine("Do you wanted to Shop anything else?? Please type YES OR NO !!");
            string userSecondChoice =  Console.ReadLine();

            switch (userSecondChoice.ToUpper())
            {
                case "YES":
                    goto start;

                case "NO":
                    break;

                default:
                    Console.WriteLine($"Your Input is invalid {userSecondChoice} Please Enter Valid Input");
                    goto decision;
                 
            }


            Console.WriteLine("Thanks for shopping with us.! Your Bill is {0} Keep shopping with us", TotalCoffeeBill);

        }
    }
}
