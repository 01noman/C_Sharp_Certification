using System;

class vowel_constant
{
    public static void Show()
    {
        Console.WriteLine("Enter a character: ");
        char letter = Convert.ToChar(Console.ReadLine());

        letter = char.ToLower(letter);
        if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
        {
            Console.WriteLine($"{letter} is a vowel.");
        }
        else
        {
            Console.WriteLine($"{letter} is not a Constant.");
        }
    }
}