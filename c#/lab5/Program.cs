using Microsoft.CSharp.RuntimeBinder;
using System;
using System.IO.Pipes;

class Program
{
    public static void Main(string[] args )
    {

        //Addition a1 = new Addition();
        //double ans = a1.Add(3, 4);
        //Console.WriteLine(ans);
        //double ans1 = a1.Add(3.4f, 5.6f);
        //Console.WriteLine(ans1);
        //Area a1 = new Area();
        //double ans  = a1.Areas(5);
        //Console.WriteLine(ans);
        //double ans1 = a1.Areas(5,6);
        //Console.WriteLine(ans1);
        //RBI r1 = new RBI();
        //r1.CalculateInterest();
        //HDFC h1 = new HDFC();
        //h1.CalculateInterest();
        //SBI s1 = new SBI();
        //s1.CalculateInterest();
        //ICICI i1 = new ICICI();
        //i1.CalculateInterest();
        Hospital h1 = new Hospital();
        h1.HospitalDetails();
        Wockhardt w1 = new Wockhardt();
        w1.HospitalDetails();
        Gokul_Superspeciality g1 = new Gokul_Superspeciality();
        g1.HospitalDetails();


    }
}