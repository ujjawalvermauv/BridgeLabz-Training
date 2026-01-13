using System;
using System.IO;

class WriteToFile
{
    static void Main()
    {
        using (StreamWriter sw = new StreamWriter("output.txt"))
        {
            Console.WriteLine("Enter text:");
            string input = Console.ReadLine();
            sw.WriteLine(input);
        }
    }
}
