using System;
					
public class Program
{
	public static void Main()
	{
		int year ;
		Console.WriteLine("Enter year");
		year = Convert.ToInt32(Console.ReadLine());
		if(year%100==0)
		{
		Console.WriteLine("Leap year");
		}
		else if(year%4==0) {
		Console.WriteLine(" leap year");
		}
		else if(year%400==0) {
		Console.WriteLine(" leap year");
		}
		else {
			Console.WriteLine("not leap year");
		}
	}
}
