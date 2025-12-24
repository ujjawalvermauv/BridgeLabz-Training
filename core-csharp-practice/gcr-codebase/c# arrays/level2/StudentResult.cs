using System;

class StudentResult
{
    static void Main(string[] args)
    {
        int students = int.Parse(Console.ReadLine());
        int[] phy = new int[students];
        int[] chem = new int[students];
        int[] math = new int[students];
        double[] percent = new double[students];
        string[] grade = new string[students];
        for (int i = 0; i < students; i++){
            phy[i] = int.Parse(Console.ReadLine());
            chem[i] = int.Parse(Console.ReadLine());
            math[i] = int.Parse(Console.ReadLine());
            percent[i] = (phy[i] + chem[i] + math[i]) / 3.0;
            if (percent[i] >= 75)
                grade[i] = "A";
            else if (percent[i] >= 60)
                grade[i] = "B";
            else
                grade[i] = "C";
        }
        for (int i = 0; i < students; i++){
            Console.WriteLine(percent[i]);
            Console.WriteLine(grade[i]);
        }
    }
}
