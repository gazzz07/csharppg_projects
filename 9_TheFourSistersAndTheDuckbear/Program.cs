// See https://aka.ms/new-console-template for more information
Console.WriteLine("How many eggs did Sister 1 collect?: ");
string sister1Text = Console.ReadLine();
int sister1Amount = Convert.ToInt32(sister1Text);

Console.WriteLine("How many eggs did Sister 2 collect?: ");
string sister2Text = Console.ReadLine();
int sister2Amount = Convert.ToInt32(sister2Text);

Console.WriteLine("How many eggs did Sister 3 collect?: ");
string sister3Text = Console.ReadLine();
int sister3Amount = Convert.ToInt32(sister3Text);

Console.WriteLine("How many eggs did Sister 4 collect?: ");
string sister4Text = Console.ReadLine();
int sister4Amount = Convert.ToInt32(sister4Text);

int sistersEggs = (sister1Amount + sister2Amount + sister3Amount + sister4Amount) / 4;
int duckbearEggs = (sister1Amount + sister2Amount + sister3Amount + sister4Amount) % 4;

Console.WriteLine($"The sisters get {sistersEggs} eggs each, and the duckbear gets {duckbearEggs}");