using System;

public class Program
{
	 static double CelsiusToFahrenheit(double celsius)
    {
        double fahrenheit = (celsius * 9 / 5) + 32;
        return fahrenheit;
    }

    static double FahrenheitToCelsius(double fahrenheit)
    {
        double celsius = (fahrenheit - 32) * 5 / 9;
        return celsius;
    }

    public static void Main(string[] args)
    {
		
        
        Console.WriteLine("1. Celsius to Fahrenheit");
        Console.WriteLine("2. Fahrenheit to Celsius");
        
        int ch = Convert.ToInt32(Console.ReadLine());

        if (ch == 1)
        {
            Console.Write("Enter temperature in Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = CelsiusToFahrenheit(celsius);
      		Console.WriteLine( celsius );
			Console.WriteLine( fahrenheit );
        } 
        else if (ch == 2)
        {
            Console.Write("Enter temperature in Fahrenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celsius = FahrenheitToCelsius(fahrenheit);
            Console.WriteLine( fahrenheit );
			Console.WriteLine( celsius );
        }
        else
        {
            Console.WriteLine("Invalid choice!");
        }

      
    }
		}

