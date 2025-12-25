using System;

class UnitConverter
{
    // Length Conversions
    public static double ConvertKmToMiles(double km) => km * 0.621371;
    public static double ConvertMilesToKm(double miles) => miles * 1.60934;
    public static double ConvertMetersToFeet(double meters) => meters * 3.28084;
    public static double ConvertFeetToMeters(double feet) => feet * 0.3048;
    public static double ConvertYardsToFeet(double yards) => yards * 3;
    public static double ConvertMetersToInches(double meters) => meters * 39.3701;
    
    // Temperature and Weight
    public static double ConvertFahrenheitToCelsius(double f) => (f - 32) * 5 / 9;
    public static double ConvertCelsiusToFahrenheit(double c) => (c * 9 / 5) + 32;
    public static double ConvertPoundsToKg(double lbs) => lbs * 0.453592;
    public static double ConvertGallonsToLiters(double gal) => gal * 3.78541;

    static void Main()
    {
        Console.WriteLine("10 Km to Miles: " + ConvertKmToMiles(10));
        Console.WriteLine("100 Fahrenheit to Celsius: " + ConvertFahrenheitToCelsius(100));
    }
}