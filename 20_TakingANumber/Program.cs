Console.WriteLine("Enter a number: ");
string userInputText = Console.ReadLine();
Console.WriteLine(AskForNumber(userInputText));

Console.WriteLine("Enter a number between 10 and 50: ");
string userInputInRange = Console.ReadLine();
Console.WriteLine(AskForNumberInRange(userInputInRange, 10, 50));

int AskForNumberInRange(string text, int min, int max)
{
    while (true)
    {

        int numberInRange = Convert.ToInt32(text);
        if (numberInRange >= 10 && numberInRange <= 50)
        {
            return numberInRange;
        }
        else
        {
            Console.WriteLine("Outside of range, try again: ");
            text = Console.ReadLine();
        }
    }
    return 0;
}

int AskForNumber(string text)
{
    int userInput = Convert.ToInt32(text);
    return userInput;
}