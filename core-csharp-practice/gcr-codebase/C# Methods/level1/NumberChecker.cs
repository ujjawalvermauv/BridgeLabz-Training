using System;

class NumberChecker
{
    public int CheckStatus(int number)
    {
        if (number > 0) return 1;
        if (number < 0) return -1;
        return 0;
    }

    static void Main()
    {
        NumberChecker checker = new NumberChecker();
        Console.Write("Enter a number: ");
        int userInput = int.Parse(Console.ReadLine());
        int result = checker.CheckStatus(userInput);
        Console.WriteLine("Status code: " + result);
    }
}