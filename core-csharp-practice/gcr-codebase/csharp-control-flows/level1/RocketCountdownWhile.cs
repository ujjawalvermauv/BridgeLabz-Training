using System;

class RocketCountdownWhile
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Enter countdown value:");
        int counter = int.Parse(Console.ReadLine());
        while (counter >= 1)
        {
            Console.WriteLine(counter);
            counter--;
        }
    }
}
