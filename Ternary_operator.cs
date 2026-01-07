using System;

class Ternary_operator
{
    public static void Show()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"a = {a}, b = {b}");
        int max = (a > b) ? a : b;
        Console.WriteLine($"Max value: {max}");
    }
}