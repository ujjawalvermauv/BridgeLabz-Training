using System;
using System.IO;
using System.Text;

class ByteToChar
{
    static void Main()
    {
        using (StreamReader sr = new StreamReader("data.bin", Encoding.UTF8))
        {
            Console.WriteLine(sr.ReadToEnd());
        }
    }
}
