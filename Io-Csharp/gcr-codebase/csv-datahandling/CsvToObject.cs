using System;
using System.IO;
using System.Collections.Generic;

class Student
{
    public int Id;
    public string Name;
    public int Age;
    public int Marks;
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();

        foreach (var line in File.ReadAllLines("students.csv"))
        {
            if (line.StartsWith("ID")) continue;

            var d = line.Split(',');
            students.Add(new Student
            {
                Id = int.Parse(d[0]),
                Name = d[1],
                Age = int.Parse(d[2]),
                Marks = int.Parse(d[3])
            });
        }

        foreach (var s in students)
            Console.WriteLine($"{s.Name} - {s.Marks}");
    }
}
