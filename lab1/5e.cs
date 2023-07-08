using System;

public class Program
{
	
    public static void Main(string[] args)
    {
		int ch ;
		Console.WriteLine("Enter choice ");
		ch = Convert.ToInt32(Console.ReadLine());
		if(ch ==1)
		{
		Console.WriteLine("Enter length of squre");
		int l = Convert.ToInt32(Console.ReadLine());
		int ans =( 4 *l);
		Console.WriteLine(ans);
		}
		else if (ch ==2)
		{
		Console.WriteLine("Enter length of Rectangle");
		int l = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter width of Rectangle");
		int b = Convert.ToInt32(Console.ReadLine());
		int ans =( l*b);
		Console.WriteLine(ans);
		}
		else if (ch ==3)
		{
		Console.WriteLine("Enter  of radius circle");
		int r = Convert.ToInt32(Console.ReadLine());
		double ans =( 2 *3.14 * r);
		Console.WriteLine(ans);
		
		}
			
		else {
		Console.WriteLine("Try Again!!!");
		
		}
		
		
		}

}