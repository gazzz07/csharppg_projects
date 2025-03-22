Console.Title = "Hunting The Manticore";

Console.WriteLine("Player 1, what is the Manticore's position?: ");
string manticorePositionText = Console.ReadLine();
int manticorePosition = Convert.ToInt32(manticorePositionText);

Console.Clear();

int manticoreHealth = 10;
int roundNumber = 1;
int cityHealth = 15;
int cannonDamage = 1;
int userGuess = -1;

if (roundNumber % 3 == 0 && roundNumber % 5 == 0)
{
    cannonDamage = 10;
}
else if (roundNumber % 3 == 0 && roundNumber % 3 != 0)
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

    Console.WriteLine("Player 2, it's your turn!");

while (manticoreHealth > 0)
{
    Console.WriteLine($"STATUS: Round: {roundNumber} City: {cityHealth}/15 Manticore: {manticoreHealth}/10");
    Console.WriteLine($"The cannon is expected to deal {cannonDamage} this round.");
    Console.WriteLine("Enter desired cannon range: ");

    if (userGuess == manticorePosition)
    {
        Console.WriteLine("That round was a DIRECT HIT!");
        manticoreHealth -= cannonDamage;
        cityHealth--;
    }
    else if (userGuess > manticorePosition)
    {
        Console.WriteLine("That round OVERSHOT the target.");
        cityHealth--;
    }
    else
    {
        Console.WriteLine("That round FELL SHORT of the target.");
        cityHealth--;
    }



}