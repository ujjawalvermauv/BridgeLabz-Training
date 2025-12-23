using System;

class LeapYearSingleIf
{
    static void Main()
    {
        int year = int.Parse(Console.ReadLine());

        if (year >= 1582 && (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0)))
        {
            Console.WriteLine("Year is a Leap Year");
        }
        else
        {
            Console.WriteLine("Year is not a Leap Year");
        }
    }
}
