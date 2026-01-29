using System;
using System.IO;

class Program
{
    static void Main()
    {
        int count = 0;

        using StreamReader reader = new StreamReader("large.csv");
        reader.ReadLine();

        while (!reader.EndOfStream)
        {
            for (int i = 0; i < 100 && !reader.EndOfStream; i++)
            {
                reader.ReadLine();
                count++;
            }
            Console.WriteLine("Processed: " + count);
        }
    }
}
