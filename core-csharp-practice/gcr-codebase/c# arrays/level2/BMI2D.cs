using System;

class BMI2D
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        double[][] personData = new double[number][];
        string[] status = new string[number];
        for (int i = 0; i < number; i++){
            personData[i] = new double[3];
            personData[i][0] = double.Parse(Console.ReadLine());
            personData[i][1] = double.Parse(Console.ReadLine());
            personData[i][2] = personData[i][0] / (personData[i][1] * personData[i][1]);
            if (personData[i][2] < 18.5)
                status[i] = "Underweight";
            else if (personData[i][2] < 25)
                status[i] = "Normal";
            else
                status[i] = "Overweight";
        }
        for (int i = 0; i < number; i++){
            Console.WriteLine(personData[i][0]);
            Console.WriteLine(personData[i][1]);
            Console.WriteLine(personData[i][2]);
            Console.WriteLine(status[i]);
        }
    }
}
