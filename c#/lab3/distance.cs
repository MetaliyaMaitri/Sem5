using System;

public class Distance
{
     int dist1;
     int dist2;
     int dist3;
public Distance(int d1, int d2)
    {
        dist1 = d1;
        dist2 = d2;
    }
public void CalculateAddition()
    {
        dist3 = dist1 + dist2;
    }
 public void DisplayAddition()
    {
        Console.WriteLine("Addition is :" +dist3);
    }
}

public class Program
{
  public  static void Main()
    {
        
        Distance distance = new Distance(5, 7);
		distance.CalculateAddition();
        distance.DisplayAddition();
    }
}
