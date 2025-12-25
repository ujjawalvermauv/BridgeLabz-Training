using System;

class HandshakeManager
{
    public int CalculateHandshakes(int n)
    {
        return (n * (n - 1)) / 2;
    }

    static void Main()
    {
        HandshakeManager manager = new HandshakeManager();
        
        Console.Write("Enter number of students: ");
        int numberOfStudents = int.Parse(Console.ReadLine());

        int totalHandshakes = manager.CalculateHandshakes(numberOfStudents);
        
        Console.WriteLine("Maximum number of handshakes: " + totalHandshakes);
    }
}