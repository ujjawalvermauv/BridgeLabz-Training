using System;
using System.Diagnostics;
using System.Text;

class PerformanceTest
{
    static void Main()
    {
        Stopwatch sw = new Stopwatch();

        sw.Start();
        string s = "";
        for (int i = 0; i < 10000; i++)
            s += "a";
        sw.Stop();
        Console.WriteLine("String time: " + sw.ElapsedMilliseconds);

        sw.Restart();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 10000; i++)
            sb.Append("a");
        sw.Stop();
        Console.WriteLine("StringBuilder time: " + sw.ElapsedMilliseconds);
    }
}
