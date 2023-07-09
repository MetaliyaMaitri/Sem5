using System;

public class Program
{
    public static void Main(string[] args)
    {
       Staff[] s = new Staff[5];
		for(int i = 0;i<=4;i++)
		{
			s[i] = new Staff();
			s[i].GetDetails();
			s[i].DisplayDetails();
		}
		 }
}
class Staff
{
     string name ;
     string post ;

    
    public void DisplayDetails()
    {
        for(int i = 0;i<=4;i++)
		{
		 if(post=="Hod")
		 {
		Console.WriteLine("Name: " + name);
        Console.WriteLine("Post: " + post);
		 }
			break;
		}
        
    }

   
    public void  GetDetails()
    {
        Console.WriteLine("Enter name");
		name = Console.ReadLine();
		 Console.WriteLine("Enter post");
		post = Console.ReadLine();
    }
}

