using System;

class switch_pattern_type
{
    public static void Show()
    {
        object obj = 42;
        // switch (obj)
        // {
        //     case int i:
        //         Console.WriteLine($"It's an integer: {i}");
        //         break;
        //     case string s:
        //         Console.WriteLine($"It's a string: {s}");
        //         break;
        //     case null:
        //         Console.WriteLine("It's null.");
        //         break;
        //     default:
        //         Console.WriteLine("It's of an unknown type.");
        //         break;
        // }

        string message = obj switch
        {
            int i => $"It's an integer: {i}",
            string s => $"It's a String: {s}",
            null => "Its a null.",
            _ => "It's of an unknown type.",
        };
        Console.WriteLine(message);
        Console.ReadKey();
    }
}