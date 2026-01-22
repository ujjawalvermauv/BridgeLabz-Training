using System;
using System.IO.Pipes;
using System.IO;
using System.Threading;

class PipeExample
{
    static void Main()
    {
        AnonymousPipeServerStream server =
            new AnonymousPipeServerStream(PipeDirection.Out, HandleInheritability.Inheritable);

        Thread reader = new Thread(() =>
        {
            using (var client = new AnonymousPipeClientStream(PipeDirection.In, server.ClientSafePipeHandle))
            using (StreamReader sr = new StreamReader(client))
            {
                Console.WriteLine(sr.ReadLine());
            }
        });

        reader.Start();

        using (StreamWriter sw = new StreamWriter(server))
        {
            sw.AutoFlush = true;
            sw.WriteLine("Hello from Writer Thread");
        }

        reader.Join();
    }
}
