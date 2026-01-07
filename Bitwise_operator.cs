using System;

class Bitwise_operator
{
    public static void Show()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"a = {a}, b = {b}");
        Console.WriteLine($"a & b: {a & b}");
        Console.WriteLine($"a | b: {a | b}");
        Console.WriteLine($"a ^ b: {a ^ b}");
        Console.WriteLine($"~a: {~a}");
        Console.WriteLine($"~b: {~b}");
        Console.WriteLine($"a << 1: {a << 1}");
        Console.WriteLine($"b >> 1: {b >> 1}");
    }
}