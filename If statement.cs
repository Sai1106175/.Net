using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Please Enter a value: ");
		int userInput =0;
		userInput= Convert.ToInt32(  Console.ReadLine()); // Converting the String type datatype into Integer
		
		if (userInput ==0)
		{
			Console.WriteLine("The given Number is 0");
		}
		
		if (userInput ==1)
		{
			Console.WriteLine("The given Number is 1");
		}
		if (userInput ==2)
		{
			Console.WriteLine("The given Number is 2");
		}
		if (userInput ==3)
		{
			Console.WriteLine("The given Number is 3");
		}
		else
				Console.WriteLine("The given number is not the rage of 1,2,3");
	
	}
	
	

}
