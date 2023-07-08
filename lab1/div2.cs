2)divisable by 2
using System;
					
public class Program
{
	public static void Main()
	{
		int i;
		Console.WriteLine("Enter the number :");
		i = Convert.ToInt32(Console.ReadLine());
		if(i%2==0){
		Console.WriteLine("{0}is the number is divisbale ",i);
		}
		else{
		  Console.WriteLine("{0} is not the divisble number ",i);
		}
	}
}

