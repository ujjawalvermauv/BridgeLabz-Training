using System;

public class TemperatureAnalyzer
{
    public static void Main()
    {
        // Example data for 7 days, 24 hours
        float[,] temps = new float[7, 24];
        double[] dailyAverages = new double[7];

        for (int day = 0; day < 7; day++)
        {
            float total = 0;
            for (int hour = 0; hour < 24; hour++)
            {
                total = total + temps[day, hour];
            }
            dailyAverages[day] = total / 24.0;
        }

        int hottestDay = 0;
        int coldestDay = 0;

        for (int i = 1; i < 7; i++)
        {
            if (dailyAverages[i] > dailyAverages[hottestDay]) hottestDay = i;
            if (dailyAverages[i] < dailyAverages[coldestDay]) coldestDay = i;
        }

        Console.WriteLine("Hottest Day Index: " + hottestDay);
        Console.WriteLine("Coldest Day Index: " + coldestDay);

        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine("Day " + i + " Average: " + dailyAverages[i]);
        }
    }
}

