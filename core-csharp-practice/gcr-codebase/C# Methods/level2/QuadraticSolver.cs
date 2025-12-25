using System;

class QuadraticSolver
{
    public double[] FindRoots(double a, double b, double c)
    {
        double delta = Math.Pow(b, 2) - (4 * a * c);

        if (delta > 0)
        {
            double r1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double r2 = (-b - Math.Sqrt(delta)) / (2 * a);
            return new double[] { r1, r2 };
        }
        else if (delta == 0)
        {
            return new double[] { -b / (2 * a) };
        }
        return new double[0];
    }

    static void Main()
    {
        QuadraticSolver solver = new QuadraticSolver();
        Console.WriteLine("For ax^2 + bx + c, enter a, b, and c:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double[] roots = solver.FindRoots(a, b, c);
        
        if (roots.Length == 0) Console.WriteLine("No real roots.");
        else foreach (double r in roots) Console.WriteLine("Root: " + r);
    }
}