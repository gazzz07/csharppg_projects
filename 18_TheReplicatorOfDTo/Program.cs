Console.Title = "The Replicator of D'To";

int[] scores = new int[5];

for (int i = 0; i < scores.Length; i++)
{
    Console.WriteLine("Enter a number: ");
    string scoreText = Console.ReadLine();
    scores[i] = Convert.ToInt32(scoreText);
}

int[] newScores = new int[5];

for (int i = 0; i < newScores.Length; i++)
{
    newScores[i] = scores[i];
}

Console.WriteLine($"First set of scores: \n {scores[0]}\t{scores[1]}\t{scores[2]}\t{scores[3]}\t{scores[4]}");
Console.WriteLine($"First set of scores: \n {newScores[0]}\t{newScores[1]}\t{newScores[2]}\t{newScores[3]}\t{newScores[4]}\n");