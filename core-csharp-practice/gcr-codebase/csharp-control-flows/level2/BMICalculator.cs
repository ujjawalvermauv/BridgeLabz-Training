using System;

class BMICalculator
{
    static void Main(string[] args)
    {
        double weight = double.Parse(Console.ReadLine());
        double heightCm = double.Parse(Console.ReadLine());

        double heightMeter = heightCm / 100;
        double bmi = weight / (heightMeter * heightMeter);

        Console.WriteLine("BMI is " + bmi);
    }
}
