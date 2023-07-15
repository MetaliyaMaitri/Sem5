public  class Stringmethod
{
    public void SMethod()
    {
        string str1 = "Hello, World!";
        string str2 = "Hello";
        string str3 = "WORLD";
        int length = str1.Length;
        Console.WriteLine("Length of str1: " + length);

       
        string concatStr = String.Concat(str2, ", ", str3);
        Console.WriteLine("Concatenated string: " + concatStr);

        
        string substring = str1.Substring(7);
        Console.WriteLine("Substring: " + substring);


    }
}