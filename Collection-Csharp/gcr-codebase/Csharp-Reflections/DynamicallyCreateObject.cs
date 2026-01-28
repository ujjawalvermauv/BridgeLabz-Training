using System;
using System.Reflection;

class Student
{
    public string Name { get; set; }
}

class Program
{
    static void Main()
    {
        Type type = typeof(Student);
        object obj = Activator.CreateInstance(type);

        type.GetProperty("Name").SetValue(obj, "Ujjawal");
        Console.WriteLine(((Student)obj).Name);
    }
}
