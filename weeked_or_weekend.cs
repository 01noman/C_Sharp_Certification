using System;

class weeked_or_weekend
{
    public static void Show()
    {
        Console.WriteLine("Enter a day of the week: ");
        string day = Console.ReadLine().ToLower();

        // switch(day)
        // {
        //     case "monday":
        //     case "tuesday":
        //     case "wednesday":
        //     case "thursday":
        //     case "friday":
        //         Console.WriteLine("It's a weekday.");
        //         break;
        //     case "saturday":
        //     case "sunday":
        //         Console.WriteLine("It's a weekend.");
        //         break;
        //     default:
        //         Console.WriteLine("It's not a valid day.");
        //         break;
        // }

        string message = day switch
        {
            "monday" => "It's a weekday.",
            "tuesday" => "It's a weekday.",
            "wednesday" => "It's a weekday.",
            "thursday" => "It's a weekday.",
            "friday" => "It's a weekday.",
            "saturday" => "It's a weekend.",
            "sunday" => "It's a weekend.",
            _ => "It's not a valid day.",
        };
        Console.WriteLine(message);
    }
}