using System;
using System.IO;

class Program
{
    static void Main()
    {
        string searchName = "Alice";

        foreach (var line in File.ReadAllLines("employees.csv"))
        {
            if (line.StartsWith("ID")) continue;

            var data = line.Split(',');

            if (data[1].Equals(searchName, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Department: {data[2]}, Salary: {data[3]}");
                break;
            }
        }
    }
}
