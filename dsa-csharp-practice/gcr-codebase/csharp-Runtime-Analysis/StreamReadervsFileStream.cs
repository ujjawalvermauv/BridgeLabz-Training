using System.IO;

using (StreamReader sr = new StreamReader("data.txt"))
{
    string content = sr.ReadToEnd();
}
