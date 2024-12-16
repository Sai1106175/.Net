using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Please Enter a value:");
		int Uservalue = int.Parse( Console.ReadLine());
		
		switch(Uservalue)
		{
			case 10:
				Console.WriteLine("The Entered value is 10");
				break;
				
			case 20:
				Console.WriteLine("The Entered Value is 20");
				break;
				
			case 30:
				 Console.WriteLine("The Entered value is 30");
				break;
				
			default:
				Console.WriteLine("The Entered value is not between 10 20 & 30");
				break;

					
			
		}
	}
	
	

}
