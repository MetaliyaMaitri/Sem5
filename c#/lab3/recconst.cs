using System;

public class Program
{
	int l;
	int b;
	Program(int l,int b)
	{
	this.l=l;
	this.b=b;
	}
    public static void Main(string[] args)
    {
		Program p =new Program(7,6);
		Console.WriteLine(p.l*p.b);
     	 }
}