using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "This is a damn stupid example.";
        string pattern = @"\b(damn|stupid)\b";

        Console.WriteLine(
            Regex.Replace(text, pattern, "****", RegexOptions.IgnoreCase)
        );
    }
}
