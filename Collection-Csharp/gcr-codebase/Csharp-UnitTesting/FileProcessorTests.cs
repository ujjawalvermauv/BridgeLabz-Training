using NUnit.Framework;
using System.IO;

[TestFixture]
public class FileProcessorTests
{
    FileProcessor processor;
    string file = "test.txt";

    [SetUp]
    public void Setup()
    {
        processor = new FileProcessor();
    }

    [Test]
    public void Write_And_Read_Test()
    {
        processor.WriteToFile(file, "Hello");
        Assert.AreEqual("Hello", processor.ReadFromFile(file));
    }

    [Test]
    public void File_Not_Found_Test()
    {
        Assert.Throws<IOException>(() => processor.ReadFromFile("nofile.txt"));
    }
}
