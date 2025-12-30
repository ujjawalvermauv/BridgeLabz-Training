using System;
public class Circle
{
    public double radius;
    // default constructor
    public Circle()
    {
        radius = 1.0; // default radius
    }
    // parameterized constructor
    public Circle(double r)
    {
        radius = r;
    }
    // method to calculate area
    private double CalculateArea()
    {
        return Math.PI * radius * radius;
    }
    // method to display area
    public void DisplayArea()
    {
        double area = CalculateArea();
        Console.WriteLine("Area of the circle: " + area);
    }
    // main method
    public static void Main()
    {
        // creating object using default constructor
        Circle circle1 = new Circle();
        // creating object using parameterized constructor
        Circle circle2 = new Circle(5.0);

        // displaying area of circles
        circle1.DisplayArea();
        circle2.DisplayArea();
    }
}


