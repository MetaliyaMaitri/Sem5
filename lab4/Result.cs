


public interface Icalculate
{
  public void Addition(int a, int b);
    public void Sub(int a, int b);

}
 public class Result : Icalculate
{
    public void Addition(int a,int b)
    {
            int   ans1 = a + b;
        Console.WriteLine("Addition " +ans1);
    }
    public void Sub (int a, int b)
    {
        int ans2 = a - b;
        Console.WriteLine("Sub " +ans2);
    }
}