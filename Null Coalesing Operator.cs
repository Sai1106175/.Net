using System;
					
public class Program
{
	public static void Main()
	{
    \\ Null Coalesing Operator.

		int? ticketsforSales = 22;
		
		int availabletickets;
		
		if(ticketsforSales == null)
		{
			Console.WriteLine("There are no tickets available.");
		}
		else
		{
			availabletickets = (int)ticketsforSales;
			
			Console.WriteLine("Available tickets ={0}", ticketsforSales);
		}
		
		
		
		
	}
}
