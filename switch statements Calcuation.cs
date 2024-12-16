using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Write a program that takes two numbers and an operator (+, -, *, /) as input.Use a switch statement to perform the operation and display the result.
            int EndResult = 0;
            Console.WriteLine("We are going to perform some Mathematical Calcuation You have to enter two numbers");
            Console.WriteLine("Please enter First Number");
            int userFirstNumber =Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Please enter Second Number");
            int userSecondNumber = Convert.ToInt32(Console.ReadLine());
            start:
            Console.WriteLine("Which Operation do you wanted to performe +, - , * , /");
            char userenteredOperation = Convert.ToChar (Console.ReadLine());

            switch (userenteredOperation)
            {
                case '+' :
                    EndResult = userFirstNumber + userSecondNumber;
                    break;

                case '-':
                    EndResult = userFirstNumber - userSecondNumber;
                    break;


                case '*':
                    EndResult = userFirstNumber * userSecondNumber;
                    break;

                case '/':
                    EndResult = userFirstNumber * userSecondNumber;
                    break;

                default:
                    Console.WriteLine($"Your entered input is {userenteredOperation} incorrect.. Please enter Valid Input. ");
                    goto start;

            }
            Console.WriteLine($"Your output is {EndResult}");


        }

    }
}
