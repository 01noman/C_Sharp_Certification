using System;

class switch_with_condition2
{
    public static void Show()
    {
        Console.WriteLine("Enter a number: ");
        
        if(int.TryParse(Console.ReadLine(), out int number))
        {
            string message = number switch
            {
                int num when num>= 0 && num <= 10 => num % 2 == 0 ? "The number is even" : "The number is odd",
                _ => "The number is out of range",
            };
            Console.WriteLine(message);
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
        Console.ReadKey();
    }
}