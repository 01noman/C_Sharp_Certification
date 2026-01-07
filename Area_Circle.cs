using System;

class Area_Circle
{
    public static void Show()
    {
        //Formula = π * r^2
        double r,Circle;
        //const double pi = 3.1416;

        Console.WriteLine("Enter the radius of the circle: ");
        r= Convert.ToDouble(Console.ReadLine());

        //Circle = pi*r*r;
        Circle =Math.PI * Math.Pow(r,2);
        Console.WriteLine($"The area of the circle is: {Circle.ToString("F2")}");

    }
}