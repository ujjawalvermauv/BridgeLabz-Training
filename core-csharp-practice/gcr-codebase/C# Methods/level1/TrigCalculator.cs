using System;

class TrigCalculator
{
    public double[] CalculateTrigonometricFunctions(double angleDegrees)
    {
        double radians = angleDegrees * (Math.PI / 180.0);
        double sinVal = Math.Sin(radians);
        double cosVal = Math.Cos(radians);
        double tanVal = Math.Tan(radians);
        return new double[] { sinVal, cosVal, tanVal };
    }

    static void Main()
    {
        TrigCalculator calc = new TrigCalculator();
        Console.Write("Enter angle in degrees: ");
        double angle = double.Parse(Console.ReadLine());

        double[] results = calc.CalculateTrigonometricFunctions(angle);
        Console.WriteLine("Sine: " + results[0]);
        Console.WriteLine("Cosine: " + results[1]);
        Console.WriteLine("Tangent: " + results[2]);
    }
}