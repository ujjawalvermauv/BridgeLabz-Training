using System;
public class AreaOfCircle
{
    // Fields (Attributes)
    private double radius;
    //method to calculate area
    public double CalculateArea()
    {
        return Math.PI * radius * radius;
    }
    //method to display area
    public void DisplayArea()
    {
        double area = CalculateArea();
        Console.WriteLine("Area of the circle: " + area);
    }
    // Main method to test the AreaOfCircle class
    public static void Main()
    {
        AreaOfCircle circle = new AreaOfCircle();
        circle.radius = 5.0; // Assigning radius value
        circle.DisplayArea();
    }


}
