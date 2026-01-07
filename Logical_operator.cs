using System;

class Logial_operator
{
    public static void Show()
    {
        bool a = true;
        bool b = false;

        Console.WriteLine($"a = {a}, b = {b}");
        Console.WriteLine($"a && b: {a && b}");
        Console.WriteLine($"a || b: {a || b}");
        Console.WriteLine($"!a: {!a}");
        Console.WriteLine($"!b: {!b}");
    }
}