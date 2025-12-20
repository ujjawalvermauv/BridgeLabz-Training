using System;

class CelsiusToFahrenheit
{
    static void Main()
    {
        double celsius;

        // Taking temperature in Celsius
        Console.Write("Enter temperature in Celsius: ");
        celsius = Convert.ToDouble(Console.ReadLine());

        // Applying conversion formula
        double fahrenheit = (celsius * 9 / 5) + 32;

        // Displaying result
        Console.WriteLine("The " + celsius + " Celsius is " + fahrenheit + " Fahrenheit");
    }
}
