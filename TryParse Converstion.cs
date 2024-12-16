using System;

public class Program
{
	public static void Main()
	{
		string givenNumber = "2395";
		int Result = 0;
		bool overallresult = int.TryParse(givenNumber, out Result); // what it trys to do is convert the int to string and stores the value in Result Variable and returns the out put in true or false value.
		if (overallresult == true)
		{
			Console.WriteLine($"The give data is integer {overallresult}");
		}
		else
		{
			Console.WriteLine($"The give data is integer {overallresult}");
		}
	}
}
