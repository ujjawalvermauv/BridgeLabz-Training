using System;

class DateArithmetic
{
    static void Main(string[] args)
    {
        Console.Write("Enter a date (yyyy-MM-dd): ");
        DateTime inputDate = DateTime.Parse(Console.ReadLine());

        // Add days, months, and years
        DateTime updatedDate = inputDate.AddDays(7).AddMonths(1).AddYears(2);

        // Subtract 3 weeks (21 days)
        updatedDate = updatedDate.AddDays(-21);

        Console.WriteLine("Final Date: " + updatedDate.ToShortDateString());
    }
}
