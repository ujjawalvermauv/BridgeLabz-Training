using System;

class Student2D{
    static void Main(string[] args){
        int students = int.Parse(Console.ReadLine());
        int[,] marks = new int[students, 3];
        double[] percent = new double[students];
        string[] grade = new string[students];
        for (int i = 0; i < students; i++){
            for (int j = 0; j < 3; j++)
                marks[i, j] = int.Parse(Console.ReadLine());
            percent[i] = (marks[i, 0] + marks[i, 1] + marks[i, 2]) / 3.0;
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
