using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string color = "#FFA500";
        string pattern = @"^#[A-Fa-f0-9]{6}$";

        Console.WriteLine(
            Regex.IsMatch(color, pattern) ? "Valid Hex Color" : "Invalid Hex Color"
        );
    }
}
