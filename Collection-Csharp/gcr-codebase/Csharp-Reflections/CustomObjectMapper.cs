using System;
using System.Collections.Generic;
using System.Reflection;

class User
{
    public string Name;
    public int Age;
}

class Program
{
    static T ToObject<T>(Dictionary<string, object> data)
    {
        T obj = Activator.CreateInstance<T>();
        foreach (var item in data)
        {
            FieldInfo field = typeof(T).GetField(item.Key);
            if (field != null)
                field.SetValue(obj, item.Value);
        }
        return obj;
    }

    static void Main()
    {
        var dict = new Dictionary<string, object>
        {
            { "Name", "Ujjawal" },
            { "Age", 22 }
        };

        User user = ToObject<User>(dict);
        Console.WriteLine($"{user.Name} - {user.Age}");
    }
}
