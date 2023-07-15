class Evenexception
{
    public void Exceptioneven()
     {
        try
        {
            int number;
            Console.WriteLine("Enter number :");
            number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 != 0)
            {
                throw new Exception("not even ");
            }
            else
            {
                Console.WriteLine("Even number");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }


}
   
}