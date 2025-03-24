(FoodSeasoning, FoodIngredient, FoodType) soupTuple;

string userSelectionType = "";
string userSelectionIngredient = "";
string userSelectionSeasoning = "";

soupTuple.Item3 = GetFoodType();
soupTuple.Item2 = GetFoodIngredient();
soupTuple.Item1 = GetFoodSeasoning();

Console.WriteLine($"You've ordered {soupTuple.Item1} {soupTuple.Item2} {soupTuple.Item3}");

FoodType GetFoodType()
{
    while (userSelectionType != "soup" && userSelectionType != "stew" && userSelectionType != "gumbo")
    {
        Console.WriteLine("Would you like soup, stew or gumbo?");
        userSelectionType = Console.ReadLine();

        switch (userSelectionType)
        {
            case "soup":
                return FoodType.Soup;
            case "stew":
                return FoodType.Stew;
            case "gumbo":
                return FoodType.Gumbo;
            default:
                break;
        }
    }
    return FoodType.Soup;
}

FoodIngredient GetFoodIngredient()
{
    while (userSelectionIngredient != "mushroom" && userSelectionIngredient != "chicken" && userSelectionIngredient != "carrot" && userSelectionIngredient != "potato")
    {
        Console.WriteLine("Would you like mushroom, chicken, carrot or potato?");
        userSelectionIngredient = Console.ReadLine();

        switch (userSelectionIngredient)
        {
            case "mushroom":
                return FoodIngredient.Mushroom;
            case "chicken":
                return FoodIngredient.Chicken;
            case "carrot":
                return FoodIngredient.Carrot;
            case "potato":
                return FoodIngredient.Potato;
            default:
                break;
        }
    }
    return FoodIngredient.Mushroom;
}

FoodSeasoning GetFoodSeasoning()
{
    while (userSelectionSeasoning != "spicy" && userSelectionSeasoning != "salty" && userSelectionSeasoning != "sweet")
    {
        Console.WriteLine("Would you like it spicy, salty or sweet?");
        userSelectionSeasoning = Console.ReadLine();

        switch (userSelectionSeasoning)
        {
            case "spicy":
                return FoodSeasoning.Spicy;
            case "salty":
                return FoodSeasoning.Salty;
            case "sweet":
                return FoodSeasoning.Sweet;
            default:
                break;
        }
    }
    return FoodSeasoning.Spicy;
}
enum FoodType
{
    Soup,
    Stew,
    Gumbo
}

enum FoodIngredient
{
    Mushroom,
    Chicken,
    Carrot,
    Potato
}

enum FoodSeasoning
{
    Spicy,
    Salty,
    Sweet
}