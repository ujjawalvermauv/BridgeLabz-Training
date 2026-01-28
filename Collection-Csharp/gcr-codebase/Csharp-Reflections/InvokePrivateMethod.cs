using System;
using System.Reflection;

class Calculator
{
    private int Multiply(int a, int b)
    {
        return a * b;
    }
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();
        MethodInfo method = typeof(Calculator)
            .GetMethod("Multiply", BindingFlags.NonPublic | BindingFlags.Instance);

        object result = method.Invoke(calc, new object[] { 3, 4 });
        Console.WriteLine("Result: " + result);
    }
}
