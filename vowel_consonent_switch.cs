using System;

class vowel_constant_switch
{
    public static void Show()
    {
        Console.WriteLine("Enter a character: ");
        char letter =  Convert.ToChar(Console.ReadLine());

        letter = char.ToLower(letter);

        switch(letter)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                Console.WriteLine($"{letter} is a vowel.");
                break;
            default:
                if(char.IsLetter(letter))
                {
                    Console.WriteLine($"{letter} is a constant.");
                }
                else
                {
                    Console.WriteLine($"{letter} is not a letter.");
                }
                break;
        }
    }
}