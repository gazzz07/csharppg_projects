Console.Title = "Discounted Inventory";

Console.WriteLine("The following items are available:\n1 - Rope\n2 - Torches\n3 - Climbing Equipment\n4 - Clean Water\n" +
    "5 - Machete\n6 - Canoe\n7 - Food Supplies\nWhat number do you want to see the price of?: ");
string itemSelectionText = Console.ReadLine();
int itemSelection = Convert.ToInt32(itemSelectionText);
Console.WriteLine("What is your name?: ");
string userName = Console.ReadLine();

switch (itemSelection)
{
    case 1:
        if (userName == "George")
        {
            Console.WriteLine("Rope costs 5 gold.");
        }
        else
        {
            Console.WriteLine("Rope costs 10 gold.");
        }
            break;
    case 2:
        if (userName == "George")
        {
            Console.WriteLine("Torches cost 8 gold.");
        }
        else
        {
            Console.WriteLine("Torches cost 16 gold.");
        }
            break;
    case 3:
        if (userName == "George")
        {
            Console.WriteLine("Climbing Equipment costs 12 gold.");
        }
        else
        {
            Console.WriteLine("Climbing Equipment costs 24 gold.");
        }
        break;
    case 4:
        if (userName == "George")
        {
            Console.WriteLine("Clean Water costs 1 gold.");
        }
        else
        {
            Console.WriteLine("Clean Water costs 2 gold.");
        }
            break;
    case 5:
        if (userName == "George")
        {
            Console.WriteLine("Machete costs 10 gold.");
        }
        else
        {
            Console.WriteLine("Machete costs 20 gold.");
        }
            break;
    case 6:
        if (userName == "George")
        {
            Console.WriteLine("Canoe costs 100 gold.");
        }
        else
        {
            Console.WriteLine("Canoe costs 200 gold.");
        }
        break;
    case 7:
        if (userName == "George")
        {
            Console.WriteLine("Food Supplies cost 1 gold.");
        }
        else
        {
            Console.WriteLine("Food Supplies cost 2 gold.");
        }
            break;
    default:
        Console.WriteLine("Invalid selection.");
        break;
}