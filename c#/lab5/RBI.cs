using System;
public class RBI
{
    public virtual void CalculateInterest()
    {
        Console.WriteLine("Calculating interest using RBI rules.");
    }
}
public class HDFC : RBI
{
    public override void  CalculateInterest()
    {
        Console.WriteLine("Calculating interest using HDFC rules.");
    }
}
public class SBI : RBI
{
    public override void CalculateInterest()
    {
        Console.WriteLine("Calculating interest using SBI rules.");
    }
}
public class ICICI : RBI
{
    public override void CalculateInterest()
    {
        Console.WriteLine("Calculating interest using ICICI rules.");
    }

}