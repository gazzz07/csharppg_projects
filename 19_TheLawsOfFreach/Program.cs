﻿int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int currentSmallest = int.MaxValue; // Start higher than anything in the array.

foreach (int i in array)
{
    if (i < currentSmallest)
        currentSmallest = i;
}
Console.WriteLine(currentSmallest);