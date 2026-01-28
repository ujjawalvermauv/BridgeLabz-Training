using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class ImportantMethodAttribute : Attribute
{
    public string Level { get; }
    public ImportantMethodAttribute(string level = "HIGH") => Level = level;
}

class Service
{
    [ImportantMethod]
    public void Save() { }

    [ImportantMethod("LOW")]
    public void Load() { }
}

class Program
{
    static void Main()
    {
        foreach (var m in typeof(Service).GetMethods())
        {
            var attr = m.GetCustomAttribute<ImportantMethodAttribute>();
            if (attr != null)
                Console.WriteLine($"{m.Name} - {attr.Level}");
        }
    }
}