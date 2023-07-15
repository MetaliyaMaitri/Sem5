class Zerodivde
{
    public void ZeroException()
    {
        try
        {
            int a;
            int b;
            Console.WriteLine("Enter a :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b :");
            b = Convert.ToInt32(Console.ReadLine());
            int ans = a / b;
            Console.WriteLine(ans);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        
        }
        
    }
}