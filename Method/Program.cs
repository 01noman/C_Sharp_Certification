using System.Security.Cryptography.X509Certificates;

class Test
{
    public static void Message(String message)
    {
        Console.WriteLine(message);
    }
    public static void Sub(int n, int n1)
    {
        int result = n-n1;
        Console.WriteLine($"The sum is: {result}");
    }

    public static void Add(int n, int n1)
    {
        int result = n+n1;
        Console.WriteLine($"The result is: {result}");
        Sub(n,n1);
    }
    public static void Main()
    {
        Message("Welcome to the Calculator...");

        int n=20;
        int n1=30;
        Add(n,n1);

        int n2=20;
        int n3=30;
        Add(n2,n3);

        Message("Good By.");
    }
}
