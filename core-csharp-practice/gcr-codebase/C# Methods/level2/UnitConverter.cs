using System;

class UnitConverter
{
    // Problem 4 
    public static double ConvertKmToMiles(double km) 
    {
        return km * 0.621371;
    }

    public static double ConvertMilesToKm(double miles) 
    {
        return miles * 1.60934;
    }

    public static double ConvertMetersToFeet(double meters) 
    {
        return meters * 3.28084;
    }

    public static double ConvertFeetToMeters(double feet) 
    {
        return feet * 0.3048;
    }

    //Problem 5
    public static double ConvertYardsToFeet(double yards) 
    {
        return yards * 3;
    }

    public static double ConvertFeetToYards(double feet) 
    {
        return feet * 0.333333;
    }

    public static double ConvertMetersToInches(double meters) 
    {
        return meters * 39.3701;
    }

    public static double ConvertInchesToMeters(double inches) 
    {
        return inches * 0.0254;
    }

    public static double ConvertInchesToCm(double inches) 
    {
        return inches * 2.54;
    }

    //Problem 6
    public static double ConvertFahrenheitToCelsius(double fahrenheit) 
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    public static double ConvertCelsiusToFahrenheit(double celsius) 
    {
        return (celsius * 9 / 5) + 32;
    }

    public static double ConvertPoundsToKilograms(double pounds) 
    {
        return pounds * 0.453592;
    }

    public static double ConvertKilogramsToPounds(double kilograms) 
    {
        return kilograms * 2.20462;
    }

    public static double ConvertGallonsToLiters(double gallons) 
    {
        return gallons * 3.78541;
    }

    public static double ConvertLitersToGallons(double liters) 
    {
        return liters * 0.264172;
    }

    static void Main()
    {
        double km = 10.0;
        double miles = ConvertKmToMiles(km);
        Console.WriteLine(km + " km is " + miles + " miles");
        
        double fahrenheit = 98.6;
        double celsius = ConvertFahrenheitToCelsius(fahrenheit);
        Console.WriteLine(fahrenheit + " F is " + celsius + " C");
    }
}