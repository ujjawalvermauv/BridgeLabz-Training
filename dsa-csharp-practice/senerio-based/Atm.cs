using System;

public class InventoryATM
{
    public static void Main()
    {
        int requestedAmount = 880;

        // Denominations and their inventory
        int[] notes = { 200, 100, 50, 20, 10, 5, 2, 1 };
        int[] inventory = { 5, 2, 10, 10, 10, 10, 10, 10 };

        int remainingAmount = requestedAmount; // Amount left to dispense
        int dispensedAmount = 0;

        Console.WriteLine("ATM TRANSACTION REPORT");
        Console.WriteLine("Requested Amount: " + requestedAmount); // Requested Amount
        Console.WriteLine(" ");

        for (int i = 0; i < notes.Length; i++)
        {
            int noteValue = notes[i];
            int availableCount = inventory[i];
            if (remainingAmount >= noteValue && availableCount > 0) // Can dispense this denomination
            {
                int needed = remainingAmount / noteValue; // Notes needed
                int toDispense = Math.Min(needed, availableCount);// Notes to dispense
                if (toDispense > 0)
                {
                    remainingAmount -= toDispense * noteValue;// Update remaining amount
                    dispensedAmount += toDispense * noteValue;// Update dispensed amount
                    inventory[i] -= toDispense; // Update inventorystatus

                    Console.WriteLine("Dispensed ₹" + noteValue + " x " + toDispense);
                }
            }
        }

        Console.WriteLine(" ");

        // Final Transaction Status
        if (remainingAmount == 0)
        {
            Console.WriteLine("TRANSACTION SUCCESSFUL");
        }
        else
        {
            Console.WriteLine("EXACT AMOUNT NOT POSSIBLE");
            Console.WriteLine("Dispensed (Fallback): ₹" + dispensedAmount);
            Console.WriteLine("Shortfall: ₹" + remainingAmount);
        }
    }
}
