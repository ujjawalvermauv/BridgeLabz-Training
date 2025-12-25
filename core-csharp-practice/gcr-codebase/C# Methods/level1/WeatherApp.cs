using System;

class WeatherApp
{
    public double CalculateWindChill(double temp, double windSpeed)
    {
        // Using Math.Pow for the exponent 0.16
        double windChill = 35.74 + 0.6215 * temp + (0.4275 * temp - 35.75) * Math.Pow(windSpeed, 0.16);
        return windChill;
    }

    static void Main()
    {
        WeatherApp app = new WeatherApp();
        Console.Write("Enter Temperature: ");
        double t = double.Parse(Console.ReadLine());
        Console.Write("Enter Wind Speed: ");
        double v = double.Parse(Console.ReadLine());
        Console.WriteLine("Wind Chill: " + app.CalculateWindChill(t, v));
    }
}