using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Enter the base of the triangle: ");
        double baseLength = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height of the triangle: ");
        double height = Convert.ToDouble(Console.ReadLine());

        
        double area = CalculateTriangleArea(baseLength, height);

        
        Console.WriteLine($"The area of the triangle with base {baseLength} and height {height} is: {area}");
    }

    static double CalculateTriangleArea(double baseLength, double height)
    {
        
        return (baseLength * height) / 2;
    }
}