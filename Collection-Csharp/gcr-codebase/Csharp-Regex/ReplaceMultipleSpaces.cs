using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "This    has     multiple spaces";
        Console.WriteLine(Regex.Replace(text, @"\s+", " "));
    }
}
