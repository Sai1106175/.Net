using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Welcome to the Coffee world.!!");
		Console.WriteLine("Here is the Menu that we have -- \n 1 Cold Coffeee - 5 Rupees \n 2 Hot Coffee -10 Rupees \n 3 Special Coffee - 20 ");
		int Userinput = int.Parse(Console.ReadLine());
		
	
		
		switch(Userinput)
		{
			case 1:
				Console.WriteLine("You have ordered COld Coffee and your bill is 5 Rupees");
			break;
			case 2:
				Console.WriteLine("You have ordered HotCoffee and your bill is 10 Rupees");
				break;
				
			case 3:
					Console.WriteLine("You have ordered Special Coffee and your bill is 20 Rupees");
				break;
				
			default:
				Console.WriteLine("You Must select from the above option");
				break;
		

		}
	
	}

}
