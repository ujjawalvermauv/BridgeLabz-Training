using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<string> ids = new HashSet<string>();

        foreach (var line in File.ReadAllLines("students.csv"))
        {
            if (line.StartsWith("ID")) continue;

            var id = line.Split(',')[0];
            if (!ids.Add(id))
                Console.WriteLine("Duplicate: " + line);
        }
    }
}
