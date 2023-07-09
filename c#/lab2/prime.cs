using System;

public class Program
{
	 

    public static void Main(string[] args)
    {
		int n ;
		Console.WriteLine("Enter number ");
		n=Convert.ToInt32(Console.ReadLine());
		for(int i = 2 ; i<=n/2;i++)
		{
		if(n%i==0)
		{
		Console.WriteLine("not prime ");
		
		}
			else {
			Console.WriteLine("prime");
			
			}
		
		}
        
       
      
    }
		}

