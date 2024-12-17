using System;

public class Program
{
	public static void Main()
	{
		string userSecondChoice;
		do	
		{
		Console.WriteLine("Please Enter a value: ");
		int UsergivenNumber = int.Parse(Console.ReadLine());
		int CompairNumber = 0;
		while(CompairNumber <= UsergivenNumber)
		{
			Console.Write(CompairNumber+" ");
			CompairNumber = CompairNumber+2;
		}
		
		
		
		do
		{
		Console.WriteLine("Would you like to Continue the program - Please type Yes or No ??");
		userSecondChoice = Console.ReadLine().ToUpper();
		
		if( userSecondChoice != "YES" && userSecondChoice !="NO")
		{
			Console.WriteLine($"The Entered input {userSecondChoice} is not Valid  Please type Yes or No  ..!!");
		}
		} while(userSecondChoice !="YES" && userSecondChoice != "NO" );
		} while( userSecondChoice == "YES");
	}
}
