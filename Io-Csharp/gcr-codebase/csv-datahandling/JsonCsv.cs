using System;
using System.IO;
using System.Text.Json;
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
        var json = File.ReadAllText("students.json");
        var students = JsonSerializer.Deserialize<List<Student>>(json);

        using StreamWriter writer = new StreamWriter("students.csv");
        writer.WriteLine("ID,Name,Age,Marks");

        foreach (var s in students)
            writer.WriteLine($"{s.Id},{s.Name},{s.Age},{s.Marks}");
    }
}
