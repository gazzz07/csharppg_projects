Console.Write("How many eggs did sister 1 get? ");
int sister1Eggs = Convert.ToInt32(Console.ReadLine());
Console.Write("How many eggs did sister 2 get? ");
int sister2Eggs = Convert.ToInt32(Console.ReadLine());
Console.Write("How many eggs did sister 3 get? ");
int sister3Eggs = Convert.ToInt32(Console.ReadLine());
Console.Write("How many eggs did sister 4 get? ");
int sister4Eggs = Convert.ToInt32(Console.ReadLine());

int combinedEggs = sister1Eggs + sister2Eggs + sister3Eggs +  sister4Eggs;

int remainderEggs = combinedEggs % 4;

Console.WriteLine($"{remainderEggs} egg(s) left over for the duckbear.");