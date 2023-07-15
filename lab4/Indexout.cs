 class Indexout
{
    public void Indexoutrange() 
    {
        try
        {
            int[] numbers = new int[5];
            for (int i = 0; i < 6; i++) 
            {
                Console.Write("Enter number ", i + 1);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        
        }
       
    }
}