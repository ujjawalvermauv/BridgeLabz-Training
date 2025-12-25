using System;

class StudentScorecard
{
    // b. Method to generate random 2-digit scores for PCM
    public static int[,] GenerateScores(int numberOfStudents)
    {
        Random random = new Random();
        int[,] scores = new int[numberOfStudents, 3]; // Columns: 0=Phys, 1=Chem, 2=Math

        for (int i = 0; i < numberOfStudents; i++)
        {
            // Generates random scores between 10 and 99
            scores[i, 0] = random.Next(10, 100); 
            scores[i, 1] = random.Next(10, 100); 
            scores[i, 2] = random.Next(10, 100); 
        }
        return scores;
    }

    // c. Method to calculate total, average, and percentage
    public static double[,] CalculateResults(int[,] scores)
    {
        int rowCount = scores.GetLength(0);
        double[,] results = new double[rowCount, 3]; // Columns: 0=Total, 1=Avg, 2=Percentage

        for (int i = 0; i < rowCount; i++)
        {
            int total = scores[i, 0] + scores[i, 1] + scores[i, 2];
            double average = total / 3.0;
            // Assuming 100 marks per subject, percentage is total / 3
            double percentage = average; 

            results[i, 0] = total;
            results[i, 1] = Math.Round(average, 2);
            results[i, 2] = Math.Round(percentage, 2);
        }
        return results;
    }

    // Utility Method to get remarks based on percentage
    public static string GetRemarks(double percentage)
    {
        if (percentage >= 80) return "A (Level 4, above standards)";
        if (percentage >= 70) return "B (Level 3, at standards)";
        if (percentage >= 60) return "C (Level 2, approaching standards)";
        if (percentage >= 50) return "D (Level 1, well below standards)";
        if (percentage >= 40) return "E (Level 1-, too below standards)";
        return "R (Remedial standards)";
    }

    // d. Method to display the scorecard in a tabular format
    public static void DisplayScorecard(int[,] scores, double[,] results)
    {
        Console.WriteLine("\nStudent Scorecard Report");
        Console.WriteLine("ID\tPhys\tChem\tMath\tTotal\tAvg\t%\tRemarks");
        Console.WriteLine("----------------------------------------------------------------------------------");

        for (int i = 0; i < scores.GetLength(0); i++)
        {
            double percentage = results[i, 2];
            string remark = GetRemarks(percentage);

            Console.WriteLine((i + 1) + "\t" + 
                              scores[i, 0] + "\t" + 
                              scores[i, 1] + "\t" + 
                              scores[i, 2] + "\t" + 
                              results[i, 0] + "\t" + 
                              results[i, 1] + "\t" + 
                              percentage + "%\t" + 
                              remark);
        }
    }

    static void Main()
    {
        // a. Take input for the number of students
        Console.Write("Enter the number of students: ");
        int studentCount = int.Parse(Console.ReadLine());

        // Generate data and perform calculations
        int[,] studentScores = GenerateScores(studentCount);
        double[,] studentResults = CalculateResults(studentScores);

        // Display results
        DisplayScorecard(studentScores, studentResults);
    }
}