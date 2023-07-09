using System;
					
public class Student
{
	int Enrollmentno;
	string name;
	int sem;
	double cpi;
	double spi;
	Student(int Enrollmentno,string name,int sem,double cpi,double spi)
	{
		this.Enrollmentno=Enrollmentno;
		this.name = name;
		this.sem=sem;
		this.cpi=cpi;
		this.spi=spi;

	}
public void DisplayDetails()
{
Console.WriteLine(Enrollmentno);
	Console.WriteLine(name);
	Console.WriteLine(sem);
	Console.WriteLine(cpi);
	Console.WriteLine(spi);
}
	public static void Main()
	{
		Student s1 = new Student(21010 ,"maitri",5,8.8,8);
		
		s1.DisplayDetails();
}
}
