using System;

class ZaraBonusCalculator
{
    // b. Method to determine Salary and years of service using 2D Array
    public static double[,] GenerateEmployeeData()
    {
        Random random = new Random();
        double[,] employeeData = new double[10, 2]; // 10 rows (employees), 2 columns (Salary, Years)

        for (int i = 0; i < 10; i++)
        {
            // Determine 5-digit salary (10000 to 99999)
            employeeData[i, 0] = random.Next(10000, 100000); 
            // Determine years of service (1 to 10 years for a 10-year-old company)
            employeeData[i, 1] = random.Next(1, 11);
        }
        return employeeData;
    }

    // c. Method to calculate new salary and bonus
    public static double[,] CalculateBonuses(double[,] oldData)
    {
        double[,] results = new double[10, 2]; // 10 rows, 2 columns (New Salary, Bonus Amount)

        for (int i = 0; i < 10; i++)
        {
            double salary = oldData[i, 0];
            double years = oldData[i, 1];
            double bonusPercentage;

            // a. 5% if service > 5 years, else 2%
            if (years > 5)
            {
                bonusPercentage = 0.05;
            }
            else
            {
                bonusPercentage = 0.02;
            }

            double bonusAmount = salary * bonusPercentage;
            results[i, 0] = salary + bonusAmount; // New Salary
            results[i, 1] = bonusAmount;          // Bonus Amount
        }
        return results;
    }

    // d. Method to Calculate sums and display in Tabular Format
    public static void DisplayFinancialReport(double[,] oldData, double[,] newData)
    {
        double sumOldSalary = 0;
        double sumNewSalary = 0;
        double totalBonus = 0;

        Console.WriteLine("Emp ID\tOld Salary\tYears\tBonus\t\tNew Salary");
        Console.WriteLine("------------------------------------------------------------------");

        for (int i = 0; i < 10; i++)
        {
            double oldSal = oldData[i, 0];
            double years = oldData[i, 1];
            double bonus = newData[i, 1];
            double newSal = newData[i, 0];

            sumOldSalary += oldSal;
            sumNewSalary += newSal;
            totalBonus += bonus;

            // Display individual employee details
            Console.WriteLine((i + 1) + "\t" + oldSal + "\t\t" + years + "\t" + bonus + "\t\t" + newSal);
        }

        Console.WriteLine("------------------------------------------------------------------");
        Console.WriteLine("TOTALS\t" + sumOldSalary + "\t\t\t" + totalBonus + "\t\t" + sumNewSalary);
    }

    static void Main()
    {
        // Generate initial data
        double[,] oldEmployeeData = GenerateEmployeeData();

        // Calculate bonuses
        double[,] newEmployeeData = CalculateBonuses(oldEmployeeData);

        // Display results
        DisplayFinancialReport(oldEmployeeData, newEmployeeData);
    }
}