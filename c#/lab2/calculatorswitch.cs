using System;
					
public class Program
{
	public static void Main()
	{
		int a,b,ch,ans;
		Console.WriteLine("Enter a :");
		a=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter b:");
		b=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter choice");
		ch = Convert.ToInt32(Console.ReadLine());
		switch(ch)
		{
			case 1 :
				ans = a+b;
				Console.WriteLine(ans);
				break;
				case 2 :
				ans = a-b;
				Console.WriteLine(ans);
				break;
				case 3 :
				ans = a*b;
				Console.WriteLine(ans);
				break;
				case 4 :
				ans = a/b;
				Console.WriteLine(ans);
				break;
		}
		
		
		
	
		
	}
}
