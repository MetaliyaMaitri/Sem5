using System;

public class Program
{
    public static long Factorial(int n)
    {
        if (n == 0)
            return 1;
        else
            return n * Factorial(n - 1);
    }

   public  static long Permutation(int n, int r)
    {
        long numerator = Factorial(n);
        long denominator = Factorial(n - r);
        return numerator / denominator;
    }

 public    static void Main()
    {
        int n = 5;
        int r = 3;
        long result = Permutation(n, r);
        Console.WriteLine("The permutation"+n + " P"+r+" is:"+ result );
    }
}
