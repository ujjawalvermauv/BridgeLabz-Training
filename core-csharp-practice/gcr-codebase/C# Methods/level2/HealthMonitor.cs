using System;

class HealthMonitor
{
    public void CalculateBmi(double[,] data)
    {
        for (int i = 0; i < data.GetLength(0); i++)
        {
            double weight = data[i, 0];
            double heightMeters = data[i, 1] / 100;
            data[i, 2] = weight / (heightMeters * heightMeters);
        }
    }

    public string GetBmiStatus(double bmi)
    {
        if (bmi < 18.5) return "Underweight";
        if (bmi < 24.9) return "Normal weight";
        if (bmi < 29.9) return "Overweight";
        return "Obese";
    }

    static void Main()
    {
        HealthMonitor hm = new HealthMonitor();
        double[,] personData = new double[10, 3];

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Enter weight (kg) for person " + (i + 1) + ": ");
            personData[i, 0] = double.Parse(Console.ReadLine());
            Console.Write("Enter height (cm) for person " + (i + 1) + ": ");
            personData[i, 1] = double.Parse(Console.ReadLine());
        }

        hm.CalculateBmi(personData);

        for (int i = 0; i < 10; i++)
        {
            double bmi = personData[i, 2];
            Console.WriteLine("Person " + (i+1) + " BMI: " + bmi + " Status: " + hm.GetBmiStatus(bmi));
        }
    }
}