using System;

class Program
{
    static void Main()
    {
        double celsius, fahrenheit;   // Declaring variables

        // Taking temperature in Celsius
        Console.Write("Enter temperature in Celsius: ");
        celsius = Convert.ToDouble(Console.ReadLine());

        // Formula: Fahrenheit = (Celsius * 9/5) + 32
        fahrenheit = (celsius * 9 / 5) + 32;

        // Displaying converted temperature
        Console.WriteLine("Temperature in Fahrenheit = " + fahrenheit);
    }
}
