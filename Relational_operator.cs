using System;

class Relational_operator
{
    public static void Show()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"a = {a}, b = {b}");
        Console.WriteLine($"a == b: {a == b}");
        Console.WriteLine($"a != b: {a != b}");
        Console.WriteLine($"a > b: {a > b}");
        Console.WriteLine($"a < b: {a < b}");
        Console.WriteLine($"a >= b: {a >= b}");
        Console.WriteLine($"a <= b: {a <= b}");
    }
}