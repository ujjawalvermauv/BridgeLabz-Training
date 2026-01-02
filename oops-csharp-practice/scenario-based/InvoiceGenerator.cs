using System;

class InvoiceGenerator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter invoice details:");
        string input = Console.ReadLine();

        string[] tasks = ParseInvoice(input);
        int totalAmount = GetTotalAmount(tasks);

        Console.WriteLine("\nInvoice Details:");
        foreach (string task in tasks)
        {
            Console.WriteLine(task.Trim());
        }

        Console.WriteLine("\nTotal Invoice Amount: " + totalAmount + " INR");
    }

    // Method to split invoice string into individual tasks
    static string[] ParseInvoice(string input)
    {
        return input.Split(',');
    }

    // Method to calculate total amount
    static int GetTotalAmount(string[] tasks)
    {
        int total = 0;

        foreach (string task in tasks)
        {
            // Example: "Logo Design - 3000 INR"
            string[] parts = task.Split('-');

            if (parts.Length == 2)
            {
                string amountPart = parts[1].Replace("INR", "").Trim();
                int amount = Convert.ToInt32(amountPart);
                total += amount;
            }
        }

        return total;
    }
}
