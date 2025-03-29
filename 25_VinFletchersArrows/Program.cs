﻿Console.WriteLine("Please pick your arrowhead: 1 - Steel, 2 - Wood, 3 - Obsidian: ");
bool arrowheadValid = false;

while (!arrowheadValid)
{

    int userArrowhead = GetUserInputInt();

    switch (userArrowhead)
    {
        case 1:
            Console.WriteLine("You chose steel");
            arrowheadValid = true;
            break;
        case 2:
            Console.WriteLine("You chose wood");
            arrowheadValid = true;
            break;
        case 3:
            Console.WriteLine("You chose obsidian");
            arrowheadValid = true;
            break;
        default:
            Console.WriteLine("Invalid. Please select a valid option: ");
            break;
    }
}
Console.WriteLine("Please pick your fletching: 2 - Plastic, 2 - Turkey Feathers, 3 - Goose Feathers");
bool fletchingValid = false;

while (!fletchingValid)
{
    int userFletching = GetUserInputInt();

    switch (userFletching)
    {
        case 1:
            Console.WriteLine("You chose plastic.");
            fletchingValid = true;
            break;
        case 2:
            Console.WriteLine("You chose turkey feathers.");
            fletchingValid = true;
            break;
        case 3:
            Console.WriteLine("You chose goose feathers.");
            fletchingValid = true;
            break;
        default:
            break;
    }
}
Console.WriteLine("Please choose the length of your arrows in centimetres (between 60 and 100): ");
bool shaftLengthValid = false;

while (!shaftLengthValid)
{
    int userShaftLength = GetUserInputInt();

    if (userShaftLength >= 60 || userShaftLength <= 100)
    {
        Console.WriteLine($"You chose {userShaftLength} centimetres.");
        shaftLengthValid = true;
    }
    else
    {
        Console.WriteLine("Please choose a valid length between 60 and 100 centimetres: ");
    }
}

Arrow userArrow = new Arrow();


GetCost();

    int GetUserInputInt()
{
        string userInput = Console.ReadLine();
    int userInputInt = Convert.ToInt32(userInput);
    return userInputInt;
}

float GetCost()
{
    return 0f;
}
class Arrow
{
    public Arrowhead arrowhead;
    public Fletching fletching;
    public float shaftLength;

    public Arrow()
        {
        this.arrowhead = Arrowhead.Steel;
        this.fletching = Fletching.Plastic;
        this.shaftLength = 1;
        }
    
    public enum Arrowhead
    {
        Steel,
        Wood,
        Obsidian
    }

    public enum Fletching
    {
        Plastic,
        Turkey_Feathers,
        Goose_Feathers
    }

}