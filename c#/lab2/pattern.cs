using System;
					
public class Program
{
	public static void Main()
	{
		 int i, j, rows, k = 1;
		 Console.Write("Enter number of rows");
        rows = Convert.ToInt32(Console.ReadLine());
		for (i = 1; i <= rows; i++)
        {
			Console.Write("\n");
            for (j = 1; j <= i; j++)
			
			Console.Write("{0} ", k++);
            Console.Write("\n");
			
	}
}
}
