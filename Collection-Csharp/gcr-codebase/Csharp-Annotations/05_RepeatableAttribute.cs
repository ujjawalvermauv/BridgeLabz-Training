using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class BugReportAttribute : Attribute
{
    public string Description { get; }
    public BugReportAttribute(string desc) => Description = desc;
}

class App
{
    [BugReport("Bug 1")]
    [BugReport("Bug 2")]
    public void Run() { }
}

class Program
{
    static void Main()
    {
        var method = typeof(App).GetMethod("Run");
        foreach (var bug in method.GetCustomAttributes<BugReportAttribute>())
            Console.WriteLine(bug.Description);
    }
}