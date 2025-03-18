// See https://aka.ms/new-console-template for more information
Console.WriteLine("How many Provinces do you have?: ");
string kingProvincesText = Console.ReadLine();
int kingProvinces = Convert.ToInt32(kingProvincesText);

Console.WriteLine("How many Duchies do you have?: ");
string kingDuchiesText = Console.ReadLine();
int kingDuchies = Convert.ToInt32(kingDuchiesText);

Console.WriteLine("How many Estates do you have?: ");
string kingEstatesText = Console.ReadLine();
int kingEstates = Convert.ToInt32(kingEstatesText);

int numOfPoints = (kingProvinces * 6) + (kingDuchies * 3) + (kingEstates * 1);

Console.WriteLine($"You scored {numOfPoints} points.");