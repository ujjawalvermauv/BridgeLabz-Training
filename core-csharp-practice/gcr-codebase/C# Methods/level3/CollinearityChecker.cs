using System;

class CollinearityChecker
{
    // b. Method using the slope formula
    public static bool CheckCollinearUsingSlope(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        // Calculate slopes: (y2 - y1) / (x2 - x1)
        double slopeAB = (y2 - y1) / (x2 - x1);
        double slopeBC = (y3 - y2) / (x3 - x2);
        double slopeAC = (y3 - y1) / (x3 - x1);

        // Points are collinear if all three slopes are equal
        return (slopeAB == slopeBC && slopeBC == slopeAC);
    }

    // c. Method using the area of triangle formula
    public static bool CheckCollinearUsingArea(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        // Area formula: 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2))
        double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));

        // Three points are collinear if the area of the triangle is 0
        return area == 0;
    }

    static void Main()
    {
        // a. Take inputs for 3 points
        // Sampling points: A(2, 4), B(4, 6), C(6, 8)
        double x1 = 2, y1 = 4;
        double x2 = 4, y2 = 6;
        double x3 = 6, y3 = 8;

        Console.WriteLine("Checking points: A(2,4), B(4,6), C(6,8)");

        // Perform checks
        bool isCollinearSlope = CheckCollinearUsingSlope(x1, y1, x2, y2, x3, y3);
        bool isCollinearArea = CheckCollinearUsingArea(x1, y1, x2, y2, x3, y3);

        // Display results
        Console.WriteLine("\n--- Results ---");
        Console.WriteLine("Collinear (Slope Method): " + isCollinearSlope);
        Console.WriteLine("Collinear (Area Method): " + isCollinearArea);
        
        if (isCollinearSlope && isCollinearArea)
        {
            Console.WriteLine("\nThe points are Collinear.");
        }
        else
        {
            Console.WriteLine("\nThe points are NOT Collinear.");
        }
    }
}