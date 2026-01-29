using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var s1 = new Dictionary<string, string[]>();
        var s2 = new Dictionary<string, string[]>();

        foreach (var l in File.ReadAllLines("students1.csv"))
        {
            if (l.StartsWith("ID")) continue;
            var d = l.Split(',');
            s1[d[0]] = d;
        }

        foreach (var l in File.ReadAllLines("students2.csv"))
        {
            if (l.StartsWith("ID")) continue;
            var d = l.Split(',');
            s2[d[0]] = d;
        }

        using var writer = new StreamWriter("merged.csv");
        writer.WriteLine("ID,Name,Age,Marks,Grade");

        foreach (var id in s1.Keys)
        {
            if (s2.ContainsKey(id))
                writer.WriteLine($"{id},{s1[id][1]},{s1[id][2]},{s2[id][1]},{s2[id][2]}");
        }
    }
}
