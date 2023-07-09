using System;
					
public class Program
{
	public static void Main()
	{
		int a,b,ch,ans;
		Console.WriteLine("Enter a :");
		a= Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter b :");
		b= Convert.ToInt32(Console.ReadLine());
		ch = Convert.ToInt32(Console.ReadLine());
		if(ch==1)
		{
		Console.WriteLine(ans=a+b);
		ans = Convert.ToInt32(Console.ReadLine());
		}
		else if(ch==2)
		{
		Console.WriteLine(ans = a-b);
		ans = Convert.ToInt32(Console.ReadLine());
		}
		else if(ch==3)
		{
		Console.WriteLine(ans = a*b);
		ans = Convert.ToInt32(Console.ReadLine());
			}
		else {
		Console.WriteLine(ans =a/b);
			ans = Convert.ToInt32(Console.ReadLine());
		}
		
}
}