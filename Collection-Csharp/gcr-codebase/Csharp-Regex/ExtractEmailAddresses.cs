using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "Contact support@example.com and info@company.org";
        string pattern = @"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}";

        foreach (Match m in Regex.Matches(text, pattern))
            Console.WriteLine(m.Value);
    }
}
