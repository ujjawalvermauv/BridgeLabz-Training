using System;

class GeometryUtility
{
    // b. Method to find the Euclidean distance between two points
    public static double CalculateDistance(double x1, double y1, double x2, double y2)
    {
        // Formula: Distance = sqrt((x2-x1)^2 + (y2-y1)^2)
        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        return distance;
    }

    // d. Method to find the equation of a line (slope and y-intercept)
    public static double[] FindLineEquation(double x1, double y1, double x2, double y2)
    {
        // m = (y2 - y1) / (x2 - x1)
        double m = (y2 - y1) / (x2 - x1);

        // b = y1 - m * x1
        double b = y1 - (m * x1);

        // Return an array having slope m and y-intercept b
        return new double[] { m, b };
    }

    static void Main()
    {
        // a. Take inputs for 2 points x1, y1 and x2, y2
        Console.WriteLine("Enter coordinates for Point 1:");
        Console.Write("x1: ");
        double x1 = double.Parse(Console.ReadLine());
        Console.Write("y1: ");
        double y1 = double.Parse(Console.ReadLine());

        Console.WriteLine("\nEnter coordinates for Point 2:");
        Console.Write("x2: ");
        double x2 = double.Parse(Console.ReadLine());
        Console.Write("y2: ");
        double y2 = double.Parse(Console.ReadLine());

        // Calculate Distance
        double distance = CalculateDistance(x1, y1, x2, y2);
        
        // Calculate Line Equation
        double[] lineParams = FindLineEquation(x1, y1, x2, y2);
        double slope = lineParams[0];
        double intercept = lineParams[1];

        // Display Results
        Console.WriteLine("\n--- Results ---");
        Console.WriteLine("Euclidean Distance: " + Math.Round(distance, 2));
        Console.WriteLine("Slope (m): " + Math.Round(slope, 2));
        Console.WriteLine("Y-Intercept (b): " + Math.Round(intercept, 2));
        Console.WriteLine("Equation of the line: y = " + Math.Round(slope, 2) + "x + " + Math.Round(intercept, 2));
    }
}