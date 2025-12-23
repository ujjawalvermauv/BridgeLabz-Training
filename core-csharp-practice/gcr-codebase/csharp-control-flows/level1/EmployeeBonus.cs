using System;

class EmployeeBonus
{
    static void Main()
    {
        double salary = double.Parse(Console.ReadLine());
        int years = int.Parse(Console.ReadLine());
        if (years > 5)
        {
            double bonus = salary * 0.05;
            Console.WriteLine("Bonus amount is " + bonus);
        }
        else
        {
            Console.WriteLine("No bonus");
        }
    }
}
