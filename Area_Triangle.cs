using System;

class Area_Triangle
{
    public static void Show()
    {
        //Formula = 1/2 * base * height
        double baseLength, height, TriangleArea;

        Console.WriteLine("Enter the base length of the triangle:");
        baseLength = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the Height of the triangle: ");
        height = Convert.ToDouble(Console.ReadLine());

        TriangleArea = 0.5 * baseLength * height;
        Console.WriteLine($"The area of the triangle is : {TriangleArea.ToString("F2")}");


    }
}