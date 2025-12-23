using System;

class StudentGrade
{
    static void Main()
    {
        int physics = int.Parse(Console.ReadLine());
        int chemistry = int.Parse(Console.ReadLine());
        int maths = int.Parse(Console.ReadLine());
        int total = physics + chemistry + maths;
        double percentage = total / 3.0;
        string grade;
        if (percentage >= 90)
            grade = "A";
        else if (percentage >= 75)
            grade = "B";
        else if (percentage >= 60)
            grade = "C";
        else
            grade = "D";

        Console.WriteLine("Average Marks: " + percentage);
        Console.WriteLine("Grade: " + grade);
    }
}
