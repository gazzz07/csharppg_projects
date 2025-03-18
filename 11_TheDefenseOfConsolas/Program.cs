Console.Title = "The Defense of Consolas";

Console.WriteLine("Target row?: ");
string rowHitText = Console.ReadLine();
int rowHit = Convert.ToInt32(rowHitText);

Console.WriteLine("Target column?: ");
string columnHitText = Console.ReadLine();
int columnHit = Convert.ToInt32(columnHitText);

Console.WriteLine($"Deploy to:");
Console.BackgroundColor = ConsoleColor.Green;
Console.WriteLine($"{columnHit - 1}, {rowHit}");
Console.WriteLine($"{columnHit + 1}, {rowHit}");
Console.WriteLine($"{rowHit - 1}, {columnHit}");
Console.WriteLine($"{rowHit + 1}, {columnHit}");
Console.Beep();