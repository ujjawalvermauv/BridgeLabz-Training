using System;
using System.IO;

class Program
{
    static void Main()
    {
        foreach (var line in File.ReadAllLines("students.csv"))
        {
            if (line.StartsWith("ID")) continue;

            var data = line.Split(',');
            int marks = int.Parse(data[3]);

            if (marks > 80)
                Console.WriteLine(line);
        }
    }
}
