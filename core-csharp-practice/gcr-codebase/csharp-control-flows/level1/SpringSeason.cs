using System;

class SpringSeason
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Enter month");
        int month = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter day");
        int day = int.Parse(Console.ReadLine());
        bool isSpring =
            (month == 3 && day >= 20) ||(month == 4) ||(month == 5) ||(month == 6 && day <= 20);

        // result
        if (isSpring)
        {
            Console.WriteLine("Its a Spring Season");
        }
        else
        {
            Console.WriteLine("Not a Spring Season");
        }
    }
}
