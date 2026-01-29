using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Regex email = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        Regex phone = new Regex(@"^\d{10}$");

        foreach (var line in File.ReadAllLines("users.csv"))
        {
            if (line.StartsWith("ID")) continue;

            var data = line.Split(',');

            if (!email.IsMatch(data[2]) || !phone.IsMatch(data[3]))
                Console.WriteLine("Invalid Row: " + line);
        }
    }
}
