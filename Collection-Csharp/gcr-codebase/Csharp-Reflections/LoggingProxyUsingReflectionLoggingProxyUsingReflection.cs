using System;
using System.Reflection;

interface IGreeting
{
    void SayHello();
}

class Greeting : IGreeting
{
    public void SayHello() => Console.WriteLine("Hello!");
}

class LoggingProxy : DispatchProxy
{
    public object Target;

    protected override object Invoke(MethodInfo method, object[] args)
    {
        Console.WriteLine("Calling: " + method.Name);
        return method.Invoke(Target, args);
    }
}

class Program
{
    static void Main()
    {
        IGreeting proxy = DispatchProxy.Create<IGreeting, LoggingProxy>();
        ((LoggingProxy)(object)proxy).Target = new Greeting();

        proxy.SayHello();
    }
}
