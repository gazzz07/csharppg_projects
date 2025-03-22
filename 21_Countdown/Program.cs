Console.Title = "Countdown";

int initialNumber = 10;

CountingDown(initialNumber);
void CountingDown(int number)
{
    if (number < 0)
    {
        return; //base case: ensures return when needed recursion finishes
    }
    
    Console.WriteLine(number);
    CountingDown(number - 1);
}