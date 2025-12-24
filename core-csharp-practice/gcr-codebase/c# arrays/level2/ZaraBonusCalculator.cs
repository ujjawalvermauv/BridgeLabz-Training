using System;

class ZaraEmployeeBonus
{
    static void Main(string[] args)
    {
        int totalEmployees = 10;
        double[] salary = new double[totalEmployees];
        double[] yearsOfService = new double[totalEmployees];
        double[] bonus = new double[totalEmployees];
        double[] newSalary = new double[totalEmployees];
        double totalOldSalary = 0;
        double totalBonus = 0;
        double totalNewSalary = 0;
        for (int i = 0; i < totalEmployees; i++)
        {
            Console.WriteLine("Enter details for Employee " + (i + 1));

            Console.Write("Enter Salary: ");
            double inputSalary = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Years of Service: ");
            double inputService = Convert.ToDouble(Console.ReadLine());
            if (inputSalary <= 0 || inputService < 0)
            {
                Console.WriteLine("Invalid input! Please enter again.\n");
                i--;
                continue;
            }

            salary[i] = inputSalary;
            yearsOfService[i] = inputService;
        }
        for (int i = 0; i < totalEmployees; i++)
        {
            if (yearsOfService[i] > 5)
            {
                bonus[i] = salary[i] * 0.05;
            }
            else
            {
                bonus[i] = salary[i] * 0.02;
            }

            newSalary[i] = salary[i] + bonus[i];
            totalOldSalary += salary[i];
            totalBonus += bonus[i];
            totalNewSalary += newSalary[i];
        }
        Console.WriteLine("\n----- Company Bonus Summary -----");
        Console.WriteLine("Total Old Salary: " + totalOldSalary);
        Console.WriteLine("Total Bonus Paid: " + totalBonus);
        Console.WriteLine("Total New Salary: " + totalNewSalary);
    }
}
