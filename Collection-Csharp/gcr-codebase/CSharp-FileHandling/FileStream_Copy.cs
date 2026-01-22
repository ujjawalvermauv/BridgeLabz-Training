using System;
using System.IO;

class FileCopy
{
    static void Main()
    {
        string sourcePath = "source.txt";
        string destPath = "destination.txt";

        try
        {
            if (!File.Exists(sourcePath))
            {
                Console.WriteLine("Source file does not exist.");
                return;
            }

            using (FileStream fsRead = new FileStream(sourcePath, FileMode.Open, FileAccess.Read))
            using (FileStream fsWrite = new FileStream(destPath, FileMode.Create, FileAccess.Write))
            {
                int data;
                while ((data = fsRead.ReadByte()) != -1)
                {
                    fsWrite.WriteByte((byte)data);
                }
            }

            Console.WriteLine("File copied successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Error: " + ex.Message);
        }
    }
}
