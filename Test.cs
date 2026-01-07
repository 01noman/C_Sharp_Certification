using System;
class Test
{
    public static void Show()
    {
        string? number = Console.ReadLine();
        if(number == null)
        {
            Console.WriteLine("No input provided.");
            return;
        }
        int numbber =  Convert.ToInt32(Console.ReadLine());
        bool result = int.TryParse(number, out int parseNumbrer);
        if(result == false)
        {
            Console.WriteLine("Invalid input for parsing.");
            Console.WriteLine($"The number enterd is: {numbber}");
            return;
        }
        int Result = int.Parse(number);
        Console.WriteLine($"Parsing result: {result}, Parsed number: {parseNumbrer}");
        Console.WriteLine($"Parsed number using int.Parse: {Result}");
        Console.WriteLine($"The numbber entered is: {numbber}");
    }
}