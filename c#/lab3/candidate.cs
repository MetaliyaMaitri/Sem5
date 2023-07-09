using System;
					
public class Program
{
	public static void Main()
	{
		Candidate c1 = new Candidate();
		c1.GetDetails();
		c1.DisplayDetails();
}
}
class Candidate{
  	int id;
	string name ;
	int age ;
	int height;
	int weight;
public void GetDetails(){
	Console.WriteLine("Enter id");
	id=Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Enter Name");
	name =  Console.ReadLine();
	Console.WriteLine("Enter age");
	age=Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Enter height");
	height=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter weight");
	weight=Convert.ToInt32(Console.ReadLine());
}
	public void DisplayDetails(){
	Console.WriteLine(id);
	Console.WriteLine(name);
	Console.WriteLine(age);
	Console.WriteLine(height);
	Console.WriteLine(weight);
		
	
	}

}
