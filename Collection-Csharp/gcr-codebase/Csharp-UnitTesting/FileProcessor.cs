using System.IO;

public class FileProcessor
{
    public void WriteToFile(string file, string content)
    {
        File.WriteAllText(file, content);
    }

    public string ReadFromFile(string file)
    {
        if (!File.Exists(file))
            throw new IOException();
        return File.ReadAllText(file);
    }
}
