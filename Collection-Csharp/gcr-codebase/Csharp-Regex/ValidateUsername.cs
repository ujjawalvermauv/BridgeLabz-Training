using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string username = "user_123";
        string pattern = @"^[A-Za-z][A-Za-z0-9_]{4,14}$";

        if (Regex.IsMatch(username, pattern))
            Console.WriteLine("Valid Username");
        else
            Console.WriteLine("Invalid Username");
    }
}
