using System;
using System.IO;
using System.Diagnostics;

class BufferedVsNormal
{
    static void CopyFile(string src, string dest, bool buffered)
    {
        byte[] buffer = new byte[4096];
        Stopwatch sw = Stopwatch.StartNew();

        using (FileStream fsRead = new FileStream(src, FileMode.Open))
        using (FileStream fsWrite = new FileStream(dest, FileMode.Create))
        {
            Stream readStream = buffered ? new BufferedStream(fsRead) : fsRead;
            Stream writeStream = buffered ? new BufferedStream(fsWrite) : fsWrite;

            int bytesRead;
            while ((bytesRead = readStream.Read(buffer, 0, buffer.Length)) > 0)
            {
                writeStream.Write(buffer, 0, bytesRead);
            }
            writeStream.Flush();
        }

        sw.Stop();
        Console.WriteLine($"{(buffered ? "Buffered" : "Normal")} Stream Time: {sw.ElapsedMilliseconds} ms");
    }

    static void Main()
    {
        CopyFile("largefile.dat", "normalCopy.dat", false);
        CopyFile("largefile.dat", "bufferedCopy.dat", true);
    }
}
