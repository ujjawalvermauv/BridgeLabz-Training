using System;

// Represents a metal pipe with prices for each length
class Pipe
{
    private int size;
    private int[] prices;

    public Pipe(int size, int[] prices)
    {
        this.size = size;
        this.prices = new int[size + 1];

        for (int i = 1; i <= size; i++)
        {
            this.prices[i] = prices[i];
        }
    }

    public int GetSize()
    {
        return size;
    }

    public int GetPrice(int length)
    {
        if (length <= 0 || length > size)
        {
            return 0;
        }
        return prices[length];
    }
}

// Handles revenue calculation using Dynamic Programming
class PipeCutPlanner
{
    private Pipe pipe;
    private int[] revenue;
    private int[] cutChoice;

    public PipeCutPlanner(Pipe pipe)
    {
        this.pipe = pipe;
        revenue = new int[pipe.GetSize() + 1];
        cutChoice = new int[pipe.GetSize() + 1];
    }

    // Scenario A: calculate maximum revenue
    public void CalculateRevenue()
    {
        revenue[0] = 0;

        for (int i = 1; i <= pipe.GetSize(); i++)
        {
            int best = -9999;
            int cut = 0;

            for (int j = 1; j <= i; j++)
            {
                int current = pipe.GetPrice(j) + revenue[i - j];

                if (current > best)
                {
                    best = current;
                    cut = j;
                }
            }

            revenue[i] = best;
            cutChoice[i] = cut;
        }
    }

    public int GetMaxRevenue()
    {
        return revenue[pipe.GetSize()];
    }

    public void ShowCutStrategy()
    {
        int remaining = pipe.GetSize();
        Console.Write("Optimal Cuts: ");

        while (remaining > 0)
        {
            Console.Write(cutChoice[remaining] + " ");
            remaining = remaining - cutChoice[remaining];
        }
        Console.WriteLine();
    }

    // Scenario B: add custom-length order
    public void AddCustomPrice(int length, int price)
    {
        if (length > pipe.GetSize())
        {
            Console.WriteLine("Custom length exceeds pipe size.");
            return;
        }

        int[] newPrices = new int[pipe.GetSize() + 1];

        for (int i = 1; i <= pipe.GetSize(); i++)
        {
            newPrices[i] = pipe.GetPrice(i);
        }

        newPrices[length] = price;

        pipe = new Pipe(pipe.GetSize(), newPrices);
        revenue = new int[pipe.GetSize() + 1];
        cutChoice = new int[pipe.GetSize() + 1];
    }
}

// Driver class
class MetalFactory
{
    static void Main(string[] args)
    {
        int[] priceTable = { 0, 1, 5, 8, 9, 10, 17, 17, 20 };
        int pipeSize = priceTable.Length - 1;

        Pipe pipe = new Pipe(pipeSize, priceTable);
        PipeCutPlanner planner = new PipeCutPlanner(pipe);

        Console.WriteLine("=== Metal Factory Pipe Cutting ===");

        // Scenario A
        planner.CalculateRevenue();
        Console.WriteLine("Maximum Revenue: " + planner.GetMaxRevenue());
        planner.ShowCutStrategy();

        // Scenario B
        planner.AddCustomPrice(3, 12);
        planner.CalculateRevenue();

        Console.WriteLine("After Custom Order:");
        Console.WriteLine("Maximum Revenue: " + planner.GetMaxRevenue());
        planner.ShowCutStrategy();
    }
}
