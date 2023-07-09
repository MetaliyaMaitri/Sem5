using System;
					
public class Program
{
	public static void Main()
	{
		int i,n;
		Console.WriteLine("enter number");
		n=Convert.ToInt32(Console.ReadLine());
		for(i=1;i<=10;i++){
		Console.WriteLine("{0}*{1}={2}",n,i,5*i);
		
		}
		
	}
}

