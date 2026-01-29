using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var output = new List<string>();

        foreach (var line in File.ReadAllLines("employees.csv"))
        {
            if (line.StartsWith("ID"))
            {
                output.Add(line);
                continue;
            }

            var data = line.Split(',');

            if (data[2] == "IT")
            {
                double salary = double.Parse(data[3]);
                data[3] = (salary * 1.10).ToString();
            }

            output.Add(string.Join(",", data));
        }

        File.WriteAllLines("employees_updated.csv", output);
    }
}
