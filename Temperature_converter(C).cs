using System;

class Temperature_converter
{
    public static void Show()
    {
        //Formula Celcius = (Fahrenheit - 32) * 5/9
        double Fahrenheit, Celcius;

        Console.WriteLine("Enter the  Temperature in Farenheit: ");
        Fahrenheit = Convert.ToDouble(Console.ReadLine());

        Celcius = (Fahrenheit - 32) * 5/9;
        Console.WriteLine($"The Temperature in Celcius is: {Celcius.ToString("F2")}");
        // Console.WriteLine($"The Temperature in Celcius is: {Celcius:F2}");
        // Console.WriteLine($"The Temperature in Celcius is: {Celcius:N2}");
    }
}