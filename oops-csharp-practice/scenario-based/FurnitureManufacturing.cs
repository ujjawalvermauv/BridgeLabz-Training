using System;

// Represents a wooden log used in furniture making
class TimberLog
{
    private int totalLength;
    private int[] rateChart;

    public TimberLog(int totalLength, int[] rateChart)
    {
        this.totalLength = totalLength;
        this.rateChart = new int[totalLength + 1];

        for (int i = 1; i <= totalLength; i++)
        {
            this.rateChart[i] = rateChart[i];
        }
    }

    public int GetLength()
    {
        return totalLength;
    }

    public int GetRate(int pieceLength)
    {
        if (pieceLength <= 0 || pieceLength > totalLength)
        {
            return 0;
        }
        return rateChart[pieceLength];
    }
}

// Plans optimal cutting strategy
class CutPlanner
{
    private TimberLog log;
    private int[] revenueTable;
    private int[] cutPlan;

    public CutPlanner(TimberLog log)
    {
        this.log = log;
        revenueTable = new int[log.GetLength() + 1];
        cutPlan = new int[log.GetLength() + 1];
    }

    // Dynamic Programming logic
    public void ComputeBestRevenue()
    {
        revenueTable[0] = 0;

        for (int len = 1; len <= log.GetLength(); len++)
        {
            int highest = -9999;
            int selectedCut = 0;

            for (int cut = 1; cut <= len; cut++)
            {
                int currentValue = log.GetRate(cut) + revenueTable[len - cut];

                if (currentValue > highest)
                {
                    highest = currentValue;
                    selectedCut = cut;
                }
            }

            revenueTable[len] = highest;
            cutPlan[len] = selectedCut;
        }
    }

    public int GetTotalRevenue()
    {
        return revenueTable[log.GetLength()];
    }

    public void ShowCutSequence()
    {
        Console.Write("Suggested cuts: ");
        int remaining = log.GetLength();

        while (remaining > 0)
        {
            Console.Write(cutPlan[remaining] + " ");
            remaining = remaining - cutPlan[remaining];
        }
        Console.WriteLine();
    }

    // Scenario: limit leftover waste
    public void ShowCutsWithWasteLimit(int allowedWaste)
    {
        Console.Write("Cuts with waste limit " + allowedWaste + ": ");
        int remaining = log.GetLength();

        while (remaining > allowedWaste)
        {
            Console.Write(cutPlan[remaining] + " ");
            remaining = remaining - cutPlan[remaining];
        }

        if (remaining > 0)
        {
            Console.Write("Waste(" + remaining + ") ");
        }
        Console.WriteLine();
    }
}

// Driver program for Story 2
class FurnitureWorkshop
{
    static void Main(string[] args)
    {
        // C# 5 safe initialization
        int[] rateList = { 0, 2, 5, 7, 8, 10, 13, 17, 17, 20, 24, 30, 34 };
        int logLength = rateList.Length - 1; // 12 units

        TimberLog log = new TimberLog(logLength, rateList);
        CutPlanner planner = new CutPlanner(log);

        Console.WriteLine(" Custom Furniture Rod Cutting ");

        planner.ComputeBestRevenue();
        Console.WriteLine("Maximum Revenue: " + planner.GetTotalRevenue());
        planner.ShowCutSequence();

        Console.WriteLine("Cuts allowing max 1 unit waste:");
        planner.ShowCutsWithWasteLimit(1);
    }
}
