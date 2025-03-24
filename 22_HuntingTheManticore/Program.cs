Console.Title = "Hunting The Manticore";

Console.WriteLine("Player 1, what is the Manticore's position?: ");
int manticorePosition = GetUserInt();

Console.Clear();

int manticoreHealth = 10;
int roundNumber = 1;
int cityHealth = 15;
int cannonDamage = 1;

Console.WriteLine("Player 2, it's your turn!");

while (manticoreHealth > 0 && cityHealth > 0)
{
    CannonDamageCalculation();

    Console.WriteLine();

    Console.WriteLine($"STATUS: Round: {roundNumber} City: {cityHealth}/15 Manticore: {manticoreHealth}/10");
    Console.WriteLine($"The cannon is expected to deal {cannonDamage} this round.");
    Console.WriteLine("Enter desired cannon range: ");
    int userGuess = GetUserInt();

    if (userGuess == manticorePosition)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("That round was a DIRECT HIT!");
        Console.ForegroundColor = ConsoleColor.White;
        manticoreHealth -= cannonDamage;
    }
    else if (userGuess > manticorePosition)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("That round OVERSHOT the target.");
        Console.ForegroundColor = ConsoleColor.White;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("That round FELL SHORT of the target.");
        Console.ForegroundColor = ConsoleColor.White;
    }

    cityHealth--;
    roundNumber++;

}
if (manticoreHealth <= 0)
{
    Winner();
}
else if (cityHealth <= 0)
{
    GameOver();
}

void CannonDamageCalculation()
{
    if (roundNumber % 3 == 0 && roundNumber % 5 == 0)
    {
        cannonDamage = 10;
    }
    else if (roundNumber % 3 == 0 && roundNumber % 5 != 0)
    {
        cannonDamage = 3;
    }
    else if (roundNumber % 3 != 0 && roundNumber % 5 == 0)
    {
        cannonDamage = 5;
    }
    else
    {
        cannonDamage = 1;
    }
}
void Winner()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Victorious! You destroyed the Manticore.");
    Console.ForegroundColor = ConsoleColor.White;
}

void GameOver()
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("The city has been destroyed, game over.");
    Console.ForegroundColor = ConsoleColor.White;
}
int GetUserInt()
{
    string userInputText = Console.ReadLine();
    int userInput = Convert.ToInt32(userInputText);
    return userInput;
}