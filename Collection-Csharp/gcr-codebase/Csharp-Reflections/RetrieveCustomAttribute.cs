using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Class)]
class AuthorAttribute : Attribute
{
    public string Name { get; }
    public AuthorAttribute(string name) => Name = name;
}

[Author("Ujjawal Verma")]
class Demo { }

class Program
{
    static void Main()
    {
        Type type = typeof(Demo);
        AuthorAttribute attr =
            (AuthorAttribute)Attribute.GetCustomAttribute(type, typeof(AuthorAttribute));

        Console.WriteLine("Author: " + attr.Name);
    }
}
