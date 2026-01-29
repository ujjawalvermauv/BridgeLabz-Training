using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        var employees = File.ReadAllLines("employees.csv")
            .Skip(1)
            .Select(l => l.Split(','))
            .OrderByDescending(e => double.Parse(e[3]))
            .Take(5);

        foreach (var e in employees)
            Console.WriteLine($"{e[1]} - {e[3]}");
    }
}
