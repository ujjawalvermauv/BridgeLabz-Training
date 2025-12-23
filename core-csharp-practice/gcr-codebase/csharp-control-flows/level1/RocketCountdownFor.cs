using System;

class RocketCountdownFor
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Enter countdown value:");
        int counter = int.Parse(Console.ReadLine());

        
        for (int i = counter; i >= 1; i--)
        {
            Console.WriteLine(i);
        }
    }
}
