using NUnit.Framework;

[TestFixture]
public class DatabaseConnectionTests
{
    DatabaseConnection db;

    [SetUp]
    public void Setup()
    {
        db = new DatabaseConnection();
        db.Connect();
    }

    [Test]
    public void Connection_Test()
    {
        Assert.IsTrue(db.IsConnected);
    }

    [TearDown]
    public void Cleanup()
    {
        db.Disconnect();
        Assert.IsFalse(db.IsConnected);
    }
}
