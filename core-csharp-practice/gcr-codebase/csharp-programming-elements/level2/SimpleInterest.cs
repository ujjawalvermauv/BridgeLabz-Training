using System;

class SimpleInterest
{
    static void Main()
    {
        double principal, rate, time;

        // Taking inputs
        Console.Write("Enter principal: ");
        principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter rate: ");
        rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter time: ");
        time = Convert.ToDouble(Console.ReadLine());

        // SI formula
        double interest = (principal * rate * time) / 100;

        // Printing output
        Console.WriteLine("The Simple Interest is " + interest + " for Principal " + principal +", Rate of Interest " + rate +  " and Time " + time);
    }
}
