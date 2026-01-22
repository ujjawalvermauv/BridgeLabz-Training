using System;
using System.IO;

class LargeFileRead
{
    static void Main()
    {
        using (StreamReader sr = new StreamReader("bigfile.txt"))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                if (line.IndexOf("error", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
