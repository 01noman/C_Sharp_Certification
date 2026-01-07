using System;

class switch_with_condition
{
    public static void Show()
    {
        Console.WriteLine("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        object result = number % 2;

        string message = result switch
        {
           0 => "The number is even.",
           _ => "The number is odd."
        };
        Console.WriteLine(message);

        // switch (number % 2)
        // {
        //     case 0:
        //         Console.WriteLine("The number is even.");
        //         break;
        //     default:
        //         Console.WriteLine("The number is odd.");
        //         break;
        // }

        // switch (number)
        // {
        //     case int num when num % 2 == 0:
        //         Console.WriteLine("The number is even.");
        //         break;
        //     case int num when num % 2 != 0:
        //         Console.WriteLine("The number is odd.");
        //         break;
        //     default:
        //         Console.WriteLine("Invalid input.");
        //         break;
        // }

        // string message = number switch
        // {
        //     int num when num % 2 == 0 => "The number is even.",
        //     int num when num % 2 != 0 => "The number is odd.",
        //     _ => "Invalid input."
        // };
    }
}