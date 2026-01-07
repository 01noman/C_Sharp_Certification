using System;

class Test2
{
    public static void Show()
    {
        int number = Convert.ToInt32(Console.ReadLine());
        int number2 = Convert.ToInt32(Console.ReadLine());
        int number3 = Convert.ToInt32(Console.ReadLine());

        int sum = number + number2 + number3;
        double average = (double)sum/3;;
        Console.WriteLine($"Sum: {sum}, Average: {average.ToString("F2")}"); // {average.ToString("F2")} for 2 decimal places

        double result = (double)number / number2;
        Console.WriteLine($"Division result: {result.ToString("F2")}");  //{result.ToString("F2")} for 2 decimal places
    }
}