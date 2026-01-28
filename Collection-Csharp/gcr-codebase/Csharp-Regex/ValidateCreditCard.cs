using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string visa = "4123456789012345";
        string pattern = @"^4\d{15}$";

        Console.WriteLine(
            Regex.IsMatch(visa, pattern) ? "Valid Visa Card" : "Invalid Card"
        );
    }
}
