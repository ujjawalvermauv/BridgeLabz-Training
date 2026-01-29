using System;
using System.Text;

class Program
{
    static string Encrypt(string text)
    {
        return Convert.ToBase64String(Encoding.UTF8.GetBytes(text));
    }

    static string Decrypt(string text)
    {
        return Encoding.UTF8.GetString(Convert.FromBase64String(text));
    }

    static void Main()
    {
        string salary = "60000";
        string encrypted = Encrypt(salary);
        string decrypted = Decrypt(encrypted);

        Console.WriteLine(encrypted);
        Console.WriteLine(decrypted);
    }
}
