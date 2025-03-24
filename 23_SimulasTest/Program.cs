Console.Title = "Simula's Test";

Chest currentState = Chest.Locked;

Console.WriteLine("The chest is locked. What do you want to do? ");


while (true)
{
    string userInput = Console.ReadLine();

    if (userInput == "unlock" && currentState == Chest.Locked)
    {
        currentState = Chest.Closed;
        Console.WriteLine("The chest is unlocked. What do you want to do? ");
    }
    if (userInput == "open" && currentState == Chest.Closed)
    {
        currentState = Chest.Open;
        Console.WriteLine("The chest is open. What do you want to do? ");
    }
    if (userInput == "close" && currentState == Chest.Open)
    {
        currentState = Chest.Closed;
        Console.WriteLine("The chest is closed. What do you want to do? ");
    }
    if (userInput == "lock" && currentState == Chest.Closed)
    {
        currentState = Chest.Locked;
        Console.WriteLine("The chest is locked. What do you want to do? ");
    }
}

enum Chest
{
    Open,
    Closed,
    Locked
}