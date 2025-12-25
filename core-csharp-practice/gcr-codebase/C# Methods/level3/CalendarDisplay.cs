using System;

class CalendarDisplay
{
    // a. Method to get the name of the month
    public static string GetMonthName(int month)
    {
        // Define a month Array to store the names of the months
        string[] months = {
            "", "January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"
        };
        return months[month];
    }

    // b. Method to check for Leap Year
    public static bool IsLeapYear(int year)
    {
        // Leap year is divisible by 4 and not 100, or divisible by 400
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }

    // b. Method to get the number of days in the month
    public static int GetNumberOfDays(int month, int year)
    {
        // Define a days Array to store the number of days in each month
        int[] days = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        
        // For Feb month, check for Leap Year to get the number of days
        if (month == 2 && IsLeapYear(year))
        {
            return 29;
        }
        return days[month];
    }

    // c. Method to get the first day of the month using Gregorian algorithm
    public static int GetFirstDayOfMonth(int month, int year)
    {
        int d = 1; // Start with the first day of the month
        int y0 = year - (14 - month) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = month + 12 * ((14 - month) / 12) - 2;
        int d0 = (d + x + (31 * m0) / 12) % 7;
        return d0; // Returns 0 for Sunday, 1 for Monday, etc.
    }

    static void Main()
    {
        // Get user input
        Console.Write("Enter Month (1-12): ");
        int month = int.Parse(Console.ReadLine());
        Console.Write("Enter Year: ");
        int year = int.Parse(Console.ReadLine());

        // Display Header
        string monthName = GetMonthName(month);
        Console.WriteLine("\n " + monthName + " " + year);
        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

        // d, e. Calculate starting day and indentation
        int firstDay = GetFirstDayOfMonth(month, year);
        int totalDays = GetNumberOfDays(month, year);

        // First for loop: proper indentation for the start of the month
        for (int i = 0; i < firstDay; i++)
        {
            Console.Write("    ");
        }

        // f. Second for loop: Display the days of the month
        for (int day = 1; day <= totalDays; day++)
        {
            // Use formatting to display integer right-justified in width 3
            Console.Write(string.Format("{0,3} ", day));

            // Move to the next line after Saturday
            if ((day + firstDay) % 7 == 0)
            {
                Console.WriteLine();
            }
        }
        Console.WriteLine("\n");
    }
}