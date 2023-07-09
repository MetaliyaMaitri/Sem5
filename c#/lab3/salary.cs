using System;
					
public class Salary
{
	double basic ;
	double TA;
	double DA;
	double HRA;
	Salary(double basic ,double TA,double DA=1.2,double HRA=2.3)
	{
		this.basic=basic;
		this.TA=TA;
		this.DA = DA;
		this.HRA =HRA;
			
	}
	public double  Calculatesalary()
	{
	double totalsalary = basic +TA+(basic*DA)+(basic *HRA);
	return totalsalary;
	}
	public static void Main()
	{
		Salary s1 = new Salary(500000,20000);
		double totalsalary = s1.Calculatesalary();
		Console.WriteLine(totalsalary);
		
		
		
}
}
