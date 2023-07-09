using System;

public class Program
{
 public   static double CalculateBMI(double weightPounds, double heightInches)
    {
         double PoundsToKg = 0.45359237;
         double InchesToMeters = 0.0254;

        double weightKg = weightPounds * PoundsToKg;

      
        double heightMeters = heightInches * InchesToMeters;

        
        double bmi = weightKg / (heightMeters * heightMeters);

        return bmi;
    }

 public   static void Main()
    {
        Console.Write("Enter weight in pounds: ");
        double weightPounds = double.Parse(Console.ReadLine());

        Console.Write("Enter height in inches: ");
        double heightInches = double.Parse(Console.ReadLine());

        double bmi = CalculateBMI(weightPounds, heightInches);
        Console.WriteLine("BMI:" + bmi + "F2"  );
    } 
}
