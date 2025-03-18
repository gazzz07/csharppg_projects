Console.Title = "The Prototype";

int userNumGuess = -1, userNumAnswer = -1;

while (userNumAnswer < 0 || userNumAnswer > 100)
{
    Console.WriteLine("Player 1, enter a number between 0 and 100: ");
    string userNumAnswerText = Console.ReadLine();
    userNumAnswer = Convert.ToInt32(userNumAnswerText);
}

Console.Clear();

while (userNumAnswer != userNumGuess)
{
    Console.WriteLine("Player 2, what is your guess?: ");
    string userNumGuessText = Console.ReadLine();
    userNumGuess = Convert.ToInt32(userNumGuessText);

    if (userNumGuess == userNumAnswer)
    {
        Console.WriteLine("That's correct!");
    }
    else if (userNumGuess < userNumAnswer)
    {
        Console.WriteLine("Incorrect, too low!");
    }
    else
    {
        Console.WriteLine("Incorrect, too high!");
    }
}