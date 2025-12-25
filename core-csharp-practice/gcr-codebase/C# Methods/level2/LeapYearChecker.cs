using System;

class LeapYearChecker
{
    public bool IsLeapYear(int year)
    {
        if (year < 1582) return false;
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }

    static void Main()
    {
        LeapYearChecker checker = new LeapYearChecker();
        Console.Write("Enter Year: ");
        int year = int.Parse(Console.ReadLine());

        if (checker.IsLeapYear(year)) Console.WriteLine(year + " is a Leap Year.");
        else Console.WriteLine(year + " is not a Leap Year.");
    }
}