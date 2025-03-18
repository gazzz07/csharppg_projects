Console.Title = "The Laws of Freach";

int[] testScores = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int currentSmallest = int.MaxValue; // Start higher than anything in the array.
foreach (int score in testScores)
{
    if (score < currentSmallest)
        currentSmallest = score;
}
Console.WriteLine(currentSmallest);

/*int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int currentSmallest = int.MaxValue; // Start higher than anything in the array.
for (int index = 0; index < array.Length; index++)
{
    if (array[index] < currentSmallest)
        currentSmallest = array[index];
}
Console.WriteLine(currentSmallest);*/

int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int total = 0;
foreach (int item in array)
    total += item;
float average = (float)total / array.Length;
Console.WriteLine(average);

/*int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int total = 0;
for (int index = 0; index < array.Length; index++)
    total += array[index];
float average = (float)total / array.Length;
Console.WriteLine(average);*/