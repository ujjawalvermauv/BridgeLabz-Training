using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class TaskInfoAttribute : Attribute
{
    public string Priority { get; set; }
    public string AssignedTo { get; set; }
}

class TaskManager
{
    [TaskInfo(Priority = "HIGH", AssignedTo = "Developer")]
    public void CompleteTask() { }
}

class Program
{
    static void Main()
    {
        var method = typeof(TaskManager).GetMethod("CompleteTask");
        var attr = method.GetCustomAttribute<TaskInfoAttribute>();
        Console.WriteLine($"{attr.Priority} - {attr.AssignedTo}");
    }
}