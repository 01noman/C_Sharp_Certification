using System;

class project1_Temperature_Converter
{
    public static void Show()
    {
        Console.WriteLine("Temperature Converter Started...");
        Console.WriteLine("1. Celsius to Fahrenheit");
        Console.WriteLine("2. Fahrenheit to Celsius");
        Console.WriteLine("Choose an option (1 or 2): ");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter temperature in Celsius: ");
                double celsius = Convert.ToDouble(Console.ReadLine());
                double fahrenheit = (celsius * 9/5) + 32;
                Console.WriteLine($"{celsius}°C is {fahrenheit:F2}°F");
                break;
            case 2:
                Console.WriteLine("Enter temperature in Fahrenheit: ");
                double Fahrenheit = Convert.ToDouble(Console.ReadLine());
                double Celsius = (Fahrenheit - 32) * 5/9;
                Console.WriteLine($"{Fahrenheit}°F is {Celsius:F2}°C");
                break;
            default:
                Console.WriteLine("Invalid Option Selected.");
                break;
        }
        Console.ReadKey();
    }
}