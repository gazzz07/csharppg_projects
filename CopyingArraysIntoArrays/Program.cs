Console.Title = "The Replicator";

int[] numberInputs = new int[5];

for (int x = 0; x < numberInputs.Length; x++)
{
    Console.Write("Please enter a number. ");
    numberInputs[x] = Convert.ToInt32(Console.ReadLine());
}

int[] copiedInputs = new int[5];

for (int x = 0;x < copiedInputs.Length; x++)
{
    copiedInputs[x] = numberInputs[x];
}

for  (int x = 0; x < copiedInputs.Length; x++)
{
    Console.WriteLine($"{numberInputs[x]} and {copiedInputs[x]}");
}