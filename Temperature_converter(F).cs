using System;

class Temperature_converter2
{
    public static void Show()
    {
        //Formula Fahrenheit = (Celsius * 9/5) + 32
        double Celsius, Fahrenheit;

        Console.WriteLine("Enter the Temperature in Celsius: ");
        Celsius = Convert.ToDouble(Console.ReadLine());

        Fahrenheit = (Celsius * 9/5) + 32;
        Console.WriteLine($"The Temperature in Fahrenheit is: {Fahrenheit.ToString("F2")}");
        // Console.WriteLine($"The Temperature in Fahrenheit is: {Fahrenheit:F2}");
        // Console.WriteLine($"The Temperature in Fahrenheit is: {Fahrenheit:N2}");
    }
}