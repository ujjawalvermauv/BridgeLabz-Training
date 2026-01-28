using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "Visit https://google.com and http://example.org";
        string pattern = @"https?://[^\s]+";

        foreach (Match m in Regex.Matches(text, pattern))
            Console.WriteLine(m.Value);
    }
}
