using System;

class Assignment_operator
{
    public static void Show()
    {
        // int a = 10;
        // int b = 20;

        // int a = Console.ReadLine() != null ? Convert.ToInt32(Console.ReadLine()) : 0;
        // int b = Console.ReadLine() != null ? Convert.ToInt32(Console.ReadLine()) : 0;
        
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Initial values: a = {a}, b = {b}");

        a += b; // a = a + b
        Console.WriteLine($"After a += b: a = {a}, b = {b}");

        a -= b; // a = a - b
        Console.WriteLine($"After a -= b: a = {a}, b = {b}");

        a *= 2; // a = a * 2
        Console.WriteLine($"After a *= 2: a = {a}, b = {b}");

        a /= 5; // a = a / 5
        Console.WriteLine($"After a /= 5: a = {a}, b = {b}");

        a %= 3; // a = a % 3
        Console.WriteLine($"After a %= 3: a = {a}, b = {b}");
    }
}