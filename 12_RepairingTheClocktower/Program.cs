Console.Title = "Repairing the Clocktower";

Console.WriteLine("Please enter a number: ");
string userInputText = Console.ReadLine();
int userInput = Convert.ToInt32(userInputText);

if (userInput % 2 == 0)
{
    Console.WriteLine("Tick");
}
else
{
    Console.WriteLine("Tock");
}