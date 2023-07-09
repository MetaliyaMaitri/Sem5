using System;
					
public class Program
{
	public static void Main()
	{
		Bank_Account b1 = new  Bank_Account();
		b1.GetAccountDetails();
		b1.DisplayAccountDetails();
		 
}
}
class Bank_Account
{
	int Account_No;
	string Email;
	 string User_name ;
	string Account_Type;
	double  Account_Balance;
 public void GetAccountDetails()
 {
 	Console.WriteLine("Enter Account no");
	 Account_No = Convert.ToInt32(Console.ReadLine());
	 Console.WriteLine("Enter  Email");
	  Email = Console.ReadLine();
	  Console.WriteLine("Enter  User_name");
	  User_name = Console.ReadLine();
	  Console.WriteLine("Enter  Account_Type");
	  Account_Type = Console.ReadLine();
	  Console.WriteLine("Enter  Account_Balance");
	   Account_Balance = Convert.ToDouble(Console.ReadLine());
}
	public void DisplayAccountDetails()
	{
		Console.WriteLine(Account_No);
		Console.WriteLine(Email);
		Console.WriteLine(User_name);
		Console.WriteLine(Account_Type);
		Console.WriteLine(Account_Balance);
	
	
	}

}