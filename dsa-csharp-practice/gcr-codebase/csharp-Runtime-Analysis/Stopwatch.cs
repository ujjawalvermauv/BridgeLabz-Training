using System;
using System.Diagnostics;

class RuntimeTest
{
    static void Main()
    {
        Stopwatch sw = Stopwatch.StartNew();

        for (int i = 0; i < 1000000; i++) { }

        sw.Stop();
        Console.WriteLine("Time: " + sw.ElapsedMilliseconds + " ms");
    }
}
