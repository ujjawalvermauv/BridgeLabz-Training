using System;

class StudentVoteChecker
{
    public bool CanStudentVote(int age)
    {
        if (age < 0) return false;
        return age >= 18;
    }

    static void Main()
    {
        StudentVoteChecker svc = new StudentVoteChecker();
        int[] ages = new int[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Enter age for student " + (i + 1) + ": ");
            ages[i] = int.Parse(Console.ReadLine());
            
            if (svc.CanStudentVote(ages[i])) Console.WriteLine("Can Vote.");
            else Console.WriteLine("Cannot Vote.");
        }
    }
}