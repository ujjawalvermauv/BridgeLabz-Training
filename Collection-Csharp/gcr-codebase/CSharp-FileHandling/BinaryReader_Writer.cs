using System;
using System.IO;

class StudentBinary
{
    static void Main()
    {
        string path = "student.dat";

        using (BinaryWriter bw = new BinaryWriter(File.Open(path, FileMode.Create)))
        {
            bw.Write(101);
            bw.Write("Ujjawal");
            bw.Write(8.7);
        }

        using (BinaryReader br = new BinaryReader(File.Open(path, FileMode.Open)))
        {
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadDouble());
        }
    }
}
