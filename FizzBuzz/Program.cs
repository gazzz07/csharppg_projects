Console.Title = "The Magic Cannon (FizzBuzz)";

for (int x = 0; x < 100; x++)
{
    if (x % 3 == 0 && x % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{x}: Fire + Electric");
    } else if (x % 3 == 0 && x % 5 != 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{x}: Fire");
    } else if (x % 3 != 0 && x % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{x}: Electric");
    } else
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"{x}: Normal");
    }
}