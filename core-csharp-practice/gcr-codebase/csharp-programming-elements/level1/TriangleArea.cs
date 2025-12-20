using System;

class TriangleArea
{
    static void Main()
    {
        double baseValue, height;

        Console.Write("Enter base: ");
        baseValue = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter height: ");
        height = Convert.ToDouble(Console.ReadLine());

        double areaCm = 0.5 * baseValue * height;
        double areaInches = areaCm / (2.54 * 2.54);

        Console.WriteLine("Area in square cm is " + areaCm + " and in square inches is " + areaInches);
    }
}
