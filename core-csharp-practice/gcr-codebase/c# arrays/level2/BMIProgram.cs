using System;

class BMIProgram
{
    static void Main(string[] args)
    {
        int persons = int.Parse(Console.ReadLine());
        double[] weight = new double[persons];
        double[] height = new double[persons];
        double[] bmi = new double[persons];
        string[] status = new string[persons];
        for (int i = 0; i < persons; i++){
            weight[i] = double.Parse(Console.ReadLine());
            height[i] = double.Parse(Console.ReadLine());
            bmi[i] = weight[i] / (height[i] * height[i]);
            if (bmi[i] < 18.5)
                status[i] = "Underweight";
            else if (bmi[i] < 25)
                status[i] = "Normal";
            else
                status[i] = "Overweight";
        }

        for (int i = 0; i < persons; i++) {
            Console.WriteLine(weight[i]);
            Console.WriteLine(height[i]);
            Console.WriteLine(bmi[i]);
            Console.WriteLine(status[i]);
        }
    }
}
