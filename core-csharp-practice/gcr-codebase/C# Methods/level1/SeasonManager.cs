using System;

class SeasonManager
{
    public bool IsSpringSeason(int month, int day)
    {
       
        if ((month == 3 && day >= 20) || (month == 4) || (month == 5) || (month == 6 && day <= 20))
        {
            return true;
        }
        return false;
    }

    static void Main()
    {
        SeasonManager manager = new SeasonManager();
        Console.Write("Enter Month (1-12): ");
        int month = int.Parse(Console.ReadLine());
        Console.Write("Enter Day (1-31): ");
        int day = int.Parse(Console.ReadLine());

        bool result = manager.IsSpringSeason(month, day);  
        if (result) Console.WriteLine("Its a Spring Season");
        else Console.WriteLine("Not a Spring Season");
    }
}