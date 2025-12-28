using System;

class DateFormatting
{
    static void Main(string[] args)
    {
        DateTime currentDate = DateTime.Now;

        Console.WriteLine("Format dd/MM/yyyy: " + currentDate.ToString("dd/MM/yyyy"));
        Console.WriteLine("Format yyyy-MM-dd: " + currentDate.ToString("yyyy-MM-dd"));
        Console.WriteLine("Format EEE, MMM dd, yyyy: " + currentDate.ToString("ddd, MMM dd, yyyy"));
    }
}
