class MyClass
{
    static void Message(string message)
    {
        Console.WriteLine(message);
    }
    static void Display()
    {
        Console.WriteLine("Invalid Input");
    }

    static int SquareFunction(int number)
    {
        int result = number*number;
        return result;
    }
    public static void Main(string[] args)
    {
        Message("Welcome to Square Calcuator...");
    
        while(true)
        {
            Console.WriteLine("Enter you number from 0 to 10 and if you Quit this Please Enter Quit.");
            string input = Console.ReadLine() ?? "";
            input = input.ToLower().Trim();
            if(input == null)
            {
                Display();
            }
            if(input == "quit")
            {
                Console.WriteLine("The Progra is terminated");
                break;
            }
            int number;
            if(!int.TryParse(input, out number))
            {
                Display();
                Console.WriteLine("Please Enter a Valid Number..");
                continue;
            }
            
            if(!(number >= 1 && number <= 10))
            {
                Console.WriteLine("The number should be 1 to 10. Please enter the number between the valid Range..");
                continue;
            }

            int result = SquareFunction(number);
            Console.WriteLine($"The Square of {number} is: {result}");
            
            Console.WriteLine("Would you like to Continue This?(yes/no)");
            string input2 = Console.ReadLine() ?? "";
            input2 = input.ToLower().Trim();
            if(input2 == "yes")
            {
                continue;
            }
            else if(input2 == "no")
            {
                Message("Thanks for Using our app..Good By");
                break;
            }

        }
    }
}