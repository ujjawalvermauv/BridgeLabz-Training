using System;
using System.Reflection;

class Person
{
    private int age = 20;
}

class Program
{
    static void Main()
    {
        Person p = new Person();
        Type type = typeof(Person);

        FieldInfo field = type.GetField("age",
            BindingFlags.NonPublic | BindingFlags.Instance);

        field.SetValue(p, 30);
        Console.WriteLine("Age: " + field.GetValue(p));
    }
}
