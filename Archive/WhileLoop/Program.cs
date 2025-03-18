Console.Title = "The Prototype - Loops";

Console.Write("User 1. Pick a number between 0 and 100. ");
int user1Number = Convert.ToInt32(Console.ReadLine());
while (user1Number < 0 ||  user1Number > 100)
{
    Console.WriteLine("Please pick a number between 0 and 100. ");
    continue;
}
Console.Clear();

Console.Write("User 2. What is your guess? ");
int user2Guess = Convert.ToInt32(Console.ReadLine());

while (user1Number != user2Guess)
{
    if (user1Number < user2Guess)
    {
        Console.WriteLine("You guessed too high. Please guess again.");
        user2Guess = Convert.ToInt32(Console.ReadLine());
        continue;
    } 
    else
    {
        Console.WriteLine("You guessed too low. Please guess again.");
        user2Guess = Convert.ToInt32(Console.ReadLine());
        continue;
    }
}
Console.WriteLine("You guessed correctly!");