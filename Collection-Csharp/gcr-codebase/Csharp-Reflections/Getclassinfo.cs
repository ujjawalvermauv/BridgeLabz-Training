using System;
using System.Reflection;

class Sample
{
    public int x;
    private string y;

    public Sample() { }
    public Sample(int a) { }

    public void Show() { }
    private void Hidden() { }
}

class Program
{
    static void Main()
    {
        Type type = typeof(Sample);

        Console.WriteLine("Methods:");
        foreach (var m in type.GetMethods(
            BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
            Console.WriteLine(m.Name);

        Console.WriteLine("\nFields:");
        foreach (var f in type.GetFields(
            BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
            Console.WriteLine(f.Name);

        Console.WriteLine("\nConstructors:");
        foreach (var c in type.GetConstructors())
            Console.WriteLine(c.ToString());
    }
}
