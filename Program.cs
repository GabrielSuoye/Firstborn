// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("What is your name?");
        string? name = Console.ReadLine();
        Console.WriteLine($"Hello {name}!\nWelcome to simple interest calculator.");

        decimal amount = 0m;

        Console.WriteLine("What is your initial deposit?");
        decimal principal = decimal.Parse(Console.ReadLine()!);

        Console.WriteLine("How long are you depositing for in years?");
        decimal time = decimal.Parse(Console.ReadLine()!);

        Console.WriteLine("What is the current rate?");
        decimal rate = decimal.Parse(Console.ReadLine()!);

        decimal interest = principal * (rate / 100m) * time;
        amount = principal + interest;

        Console.WriteLine(
            $"Your amount after {time} years is: {amount:N2}\n and has yielded {interest:N2} interest."
        );
    }
}
