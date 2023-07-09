using System;
					
public class Program
{
	public static void Main()
	{
		int n,sum=0,m;
		Console.WriteLine("Enter the number ");
		n=Convert.ToInt32(Console.ReadLine());
		while(n>0){
			m=n%10;
			sum=sum+m;
			n=n/10;
			}
		
		Console.WriteLine("{0}sum of the number ",sum);
	}
}