using System;
using System.IO;

class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("students.csv");
        int count = lines.Length - 1;

        Console.WriteLine("Total Records: " + count);
    }
}
