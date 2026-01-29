using System;
using System.IO;

class Program
{
    static void Main()
    {
        using StreamWriter writer = new StreamWriter("employees.csv");
        writer.WriteLine("ID,Name,Department,Salary");

        // Assume values fetched from DB
        writer.WriteLine("1,Alice,IT,60000");
        writer.WriteLine("2,Bob,HR,45000");
    }
}
