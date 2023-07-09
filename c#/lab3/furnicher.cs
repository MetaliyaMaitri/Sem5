using System;

public class Program
{
	
    public static void Main(string[] args)
    {
	 Table table = new Table
        {
            Material = "Wood",
		 	Price = 15,
		 	Height = 40,
		 Surface = "ok" 
		 
        };
	Console.WriteLine(table.Material);
		Console.WriteLine(table.Price+"millon");
		Console.WriteLine(table.Height+"inchis");
		Console.WriteLine(table.Surface);
	
       
     	 }
}
class Furnicher{
 public string Material;
 public double Price;

}
class Table : Furnicher{
public 	int Height;
	public string  Surface;
	
}