using System;
using System.IO;

class UpperToLower
{
    static void Main()
    {
        using (BufferedStream bs = new BufferedStream(File.OpenRead("input.txt")))
        using (StreamReader sr = new StreamReader(bs))
        using (StreamWriter sw = new StreamWriter("output.txt"))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                sw.WriteLine(line.ToLower());
            }
        }
    }
}
