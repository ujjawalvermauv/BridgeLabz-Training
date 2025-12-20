using System;

class FahrenheitToCelsius
{
    static void Main()
    {
        double fahrenheit;

        // Taking temperature in Fahrenheit
        Console.Write("Enter temperature in Fahrenheit: ");
        fahrenheit = Convert.ToDouble(Console.ReadLine());

        // Conversion formula
        double celsius = (fahrenheit - 32) * 5 / 9;

        // Displaying result
        Console.WriteLine("The " + fahrenheit + " Fahrenheit is " + celsius + " Celsius");
    }
}
