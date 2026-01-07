using System;

class Unary_operator
{
    public static void Show()
    {
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"a = {a}");
        Console.WriteLine($"-a: {-a}");
        Console.WriteLine($"+a: {+a}");
        Console.WriteLine($"a++: {a++}");
        Console.WriteLine($"a--: {a--}");
        Console.WriteLine($"++a: {++a}");
        Console.WriteLine($"--a: {--a}");
    }
}