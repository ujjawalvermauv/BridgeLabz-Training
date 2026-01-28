using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Field)]
class InjectAttribute : Attribute { }

class Service
{
    public void Run() => Console.WriteLine("Service Running");
}

class Client
{
    [Inject]
    public Service service;
}

class Program
{
    static void Main()
    {
        Client client = new Client();

        foreach (FieldInfo field in typeof(Client).GetFields())
        {
            if (Attribute.IsDefined(field, typeof(InjectAttribute)))
            {
                object dependency = Activator.CreateInstance(field.FieldType);
                field.SetValue(client, dependency);
            }
        }

        client.service.Run();
    }
}
