Console.Title = "Watchtower";

Console.WriteLine("Please enter a value for x: ");
string xText = Console.ReadLine();
int x = Convert.ToInt32(xText);

Console.WriteLine("Please enter a value for y: ");
string yText = Console.ReadLine();
int y = Convert.ToInt32(yText);


if (x < 0)
{
    if (y < 0)
    {
        Console.WriteLine("SouthWest!");
    }
    else if (y == 0)
    {
        Console.WriteLine("West!");
    }
    else
    {
        Console.WriteLine("NorthWest!");
    }
}
else if (x == 0)
{
    if (y < 0)
    {
        Console.WriteLine("South!");
    }
    else if (y == 0)
    {
        Console.WriteLine("They are here!");
    }
    else
    {
        Console.WriteLine("North!");
    }
}
else if (x > 0)
{
    if (y < 0)
    {
        Console.WriteLine("SouthEast!");
    }
    else if (y == 0)
    {
        Console.WriteLine("East!");
    }
    else
    {
        Console.WriteLine("NorthEast!");
    }
}