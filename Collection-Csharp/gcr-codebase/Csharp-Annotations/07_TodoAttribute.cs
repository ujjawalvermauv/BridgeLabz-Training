using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class TodoAttribute : Attribute
{
    public string Task;
    public string AssignedTo;
    public string Priority;

    public TodoAttribute(string task, string assignedTo, string priority = "MEDIUM")
    {
        Task = task;
        AssignedTo = assignedTo;
        Priority = priority;
    }
}

class Project
{
    [Todo("Fix Bug", "Dev1", "HIGH")]
    public void Login() { }

    [Todo("Add Logs", "Dev2")]
    public void Logging() { }
}

class Program
{
    static void Main()
    {
        foreach (var m in typeof(Project).GetMethods())
        {
            var todo = m.GetCustomAttribute<TodoAttribute>();
            if (todo != null)
                Console.WriteLine($"{todo.Task} - {todo.AssignedTo} - {todo.Priority}");
        }
    }
}