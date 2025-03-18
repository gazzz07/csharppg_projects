Console.Title = "Buying Inventory";

Console.WriteLine("The following items are available:\n1 - Rope\n2 - Torches\n3 - Climbing Equipment\n4 - Clean Water\n" +
    "5 - Machete\n6 - Canoe\n7 - Food Supplies\nWhat number do you want to see the price of?: ");
string itemSelectionText = Console.ReadLine();
int itemSelection = Convert.ToInt32(itemSelectionText);

switch (itemSelection)
{
    case 1:
        Console.WriteLine("Rope costs 10 gold.");
        break;
    case 2:
        Console.WriteLine("Torches cost 16 gold.");
        break;
    case 3:
        Console.WriteLine("Climbing Equipment costs 24 gold.");
        break;
    case 4:
        Console.WriteLine("Clean Water costs 2 gold.");
        break;
    case 5:
        Console.WriteLine("Machete costs 20 gold.");
        break;
    case 6:
        Console.WriteLine("Canoe costs 200 gold.");
        break;
    case 7:
        Console.WriteLine("Food Supplies cost 2 gold.");
        break;
    default:
        Console.WriteLine("Invalid selection.");
        break;
}