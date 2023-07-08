using System;
					
public class Program
{
	public static void Main()
	{
		int p,r,t,n;
		Console.WriteLine("Enter choice 1:");	
		Console.WriteLine("Enter choice 2:");	
		
		int ch;
		ch = Convert.ToInt32(Console.ReadLine());
		switch(ch)
		{
			case 1:
				Console.WriteLine("Enter P:");
				p=Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Enter R:");
				r=Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Enter T:");
				t=Convert.ToInt32(Console.ReadLine());
				Double si=(p*r*t)/100;
				Console.WriteLine("Si = {0} ",si);
				break;
			case 2:
				Console.WriteLine("Enter Sub1:");
				int a=Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Enter Sub2:");
				int b=Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Enter Sub3:");
				int c=Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Enter Sub4:");
				int d=Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Enter Sub5:");
				int e=Convert.ToInt32(Console.ReadLine());
				Double total=(a+b+c+d+e)/5;
				Console.WriteLine(total);
				if(total>30)
				{
					Console.WriteLine("grade d");
				}
				else if(total>40&&total<60)
				{
				Console.WriteLine("grade c");
				}
				else if(total>60&&total<80)
				{
				Console.WriteLine("grade b");
				}
				else
				{
				Console.WriteLine("Grade a");
				}
				break;
				}
	
		
	
		
	}
}
