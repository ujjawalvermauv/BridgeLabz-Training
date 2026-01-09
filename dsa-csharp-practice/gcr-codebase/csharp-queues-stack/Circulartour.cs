using System;

class CircularTour
{
    static int FindStart(int[] petrol, int[] distance)
    {
        int start = 0, deficit = 0, balance = 0;

        for (int i = 0; i < petrol.Length; i++)
        {
            balance += petrol[i] - distance[i];

            if (balance < 0)
            {
                deficit += balance;
                start = i + 1;
                balance = 0;
            }
        }

        return (balance + deficit >= 0) ? start : -1;
    }

    static void Main()
    {
        int[] petrol = { 6, 3, 7 };
        int[] distance = { 4, 6, 3 };

        Console.WriteLine(FindStart(petrol, distance));
    }
}
