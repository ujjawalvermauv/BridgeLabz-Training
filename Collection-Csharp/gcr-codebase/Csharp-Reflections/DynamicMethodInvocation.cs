using System;
using System.Reflection;

class MathOperations
{
    public int Add(int a, int b) => a + b;
    public int Subtract(int a, int b) => a - b;
    public int Multiply(int a, int b) => a * b;
}

class Program
{
    static void Main()
    {
        MathOperations obj = new MathOperations();
        Console.Write("Enter method name: ");
        string methodName = Console.ReadLine();

        MethodInfo method = typeof(MathOperations).GetMethod(methodName);
        object result = method.Invoke(obj, new object[] { 5, 3 });

        Console.WriteLine("Result: " + result);
    }
}
