using System;

class FestivalLuckyDraw
{
    public static void Main()
    {
        Console.WriteLine("Enter the number of participants:");
        int user = int.Parse(Console.ReadLine());

        for (int i = 1; i <= user; i++)
        {
            Console.Write("Enter lucky number for participant " + i + ": ");
            int Number = int.Parse(Console.ReadLine());

            // Invalid input check
            if (Number <= 0)
            {
                Console.WriteLine("Invalid number. Skipping participant " + i);
                continue;
            }

            // Lucky draw condition
            if (Number % 3 == 0 && Number % 5 == 0)
            {
                Console.WriteLine("Participant " + i + " wins a Gift Hamper!");
            }
            else
            {
                Console.WriteLine("Sorry, Participant " + i + " did not win.");
            }
        }
    }
}
