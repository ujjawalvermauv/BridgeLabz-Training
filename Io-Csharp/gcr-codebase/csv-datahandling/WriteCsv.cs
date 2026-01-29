using System;
using System.IO;

class Program
{
    static void Main()
    {
        string[] employees =
        {
            "ID,Name,Department,Salary","1,Alice,IT,60000","2,Bob,HR,45000","3,Charlie,Finance,70000","4,David,IT,80000",
            "5,Eva,Marketing,50000"
        };

        File.WriteAllLines("employees.csv", employees);
        Console.WriteLine("CSV file created successfully");
    }
}
