using System;

class InterestCalculator
{
    public double CalculateSimpleInterest(double principal, double rate, double time)
    {
        double interest = (principal * rate * time) / 100;
        return interest;
    }

    static void Main()
    {
        InterestCalculator calculator = new InterestCalculator();
        
        Console.Write("Enter Principal: ");
        double principal = double.Parse(Console.ReadLine());
        
        Console.Write("Enter Rate: ");
        double rate = double.Parse(Console.ReadLine());
        
        Console.Write("Enter Time: ");
        double time = double.Parse(Console.ReadLine());

        double result = calculator.CalculateSimpleInterest(principal, rate, time);
        
        Console.WriteLine("The Simple Interest is " + result + " for Principal " + principal + ", Rate of Interest " + rate + " and Time " + time);
    }
}