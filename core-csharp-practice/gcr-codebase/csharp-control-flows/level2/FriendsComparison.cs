using System;

class FriendsComparison
{
    static void Main(string[] args)
    {
        int amarAge = int.Parse(Console.ReadLine());
        int akbarAge = int.Parse(Console.ReadLine());
        int anthonyAge = int.Parse(Console.ReadLine());
        double amarHeight = double.Parse(Console.ReadLine());
        double akbarHeight = double.Parse(Console.ReadLine());
        double anthonyHeight = double.Parse(Console.ReadLine());

        if (amarAge < akbarAge && amarAge < anthonyAge)
            Console.WriteLine("Amar is youngest");
        else if (akbarAge < anthonyAge)
            Console.WriteLine("Akbar is youngest");
        else
            Console.WriteLine("Anthony is youngest");

        if (amarHeight > akbarHeight && amarHeight > anthonyHeight)
            Console.WriteLine("Amar is tallest");
        else if (akbarHeight > anthonyHeight)
            Console.WriteLine("Akbar is tallest");
        else
            Console.WriteLine("Anthony is tallest");
    }
}
