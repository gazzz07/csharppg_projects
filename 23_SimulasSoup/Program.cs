
Console.WriteLine("Would you like soup, stew or gumbo?");
string userSelectionType = Console.ReadLine();

switch (userSelectionType)
{
    case soup:
        userSelectionType = FoodType.Soup;
        break;
    case stew:
        userSelectionType = FoodType.Stew;
}

Console.WriteLine("Which ingredient would you like? Mushrooms, chicken, carrots or potatoes?");
string userSelectionIngredient = Console.ReadLine();

Console.WriteLine("Would you like it to be salty, spicy or sweet?");
string userSelectionSeasoning = Console.ReadLine();

(string, string, string) meal = ($"{userSelectionSeasoning}, {userSelectionIngredient},  {userSelectionType}");

Console.WriteLine($"You've ordered {meal}");

enum FoodType
{
    Soup,
    Stew,
    Gumbo
}

enum FoodIngredient
{
    Mushrooms,
    Chicken,
    Carrots,
    Potatoes
}

enum FoodSeasoning
{
    Spicy,
    Salty,
    Sweet
}