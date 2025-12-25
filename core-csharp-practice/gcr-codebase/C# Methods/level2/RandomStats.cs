using System;

class RandomStats
{
    public int[] Generate4DigitRandomArray(int size)
    {
        Random rand = new Random();
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = rand.Next(1000, 10000);
        }
        return arr;
    }

    public double[] FindAverageMinMax(int[] numbers)
    {
        double sum = 0;
        int min = numbers[0];
        int max = numbers[0];

        foreach (int n in numbers)
        {
            sum += n;
            min = Math.Min(min, n);
            max = Math.Max(max, n);
        }

        return new double[] { sum / numbers.Length, min, max };
    }

    static void Main()
    {
        RandomStats rs = new RandomStats();
        int[] myNumbers = rs.Generate4DigitRandomArray(5);
        double[] stats = rs.FindAverageMinMax(myNumbers);

        Console.WriteLine("Average: " + stats[0]);
        Console.WriteLine("Min: " + stats[1]);
        Console.WriteLine("Max: " + stats[2]);
    }
}