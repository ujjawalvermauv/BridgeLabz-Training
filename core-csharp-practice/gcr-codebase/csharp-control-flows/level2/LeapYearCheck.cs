using System;

class LeapYearCheck
{
    static void Main(string[] args)
    {
        int year = int.Parse(Console.ReadLine());
        if (year >= 1582)
        {
            if (year % 400 == 0)
            {
                Console.WriteLine("Year is a Leap Year");
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine("Year is not a Leap Year");
            }
            else if (year % 4 == 0)
            {
                Console.WriteLine("Year is a Leap Year");
            }
            else
            {
                Console.WriteLine("Year is not a Leap Year");
            }
        }
        else
        {
            Console.WriteLine("Year must be 1582 or later");
        }
    }
}
