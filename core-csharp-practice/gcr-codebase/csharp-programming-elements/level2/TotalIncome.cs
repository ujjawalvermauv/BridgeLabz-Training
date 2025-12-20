using System;

class TotalIncome
{
    static void Main()
    {
        double salary, bonus;

        // Taking salary input
        Console.Write("Enter salary: ");
        salary = Convert.ToDouble(Console.ReadLine());

        // Taking bonus input
        Console.Write("Enter bonus: ");
        bonus = Convert.ToDouble(Console.ReadLine());

        // Calculating total income
        double totalIncome = salary + bonus;

        // Printing result
        Console.WriteLine("The salary is INR " + salary +" and bonus is INR " + bonus + "Hence Total Income is INR " + totalIncome);
    }
}
