int result = AskForNumber("What is the airspeed velocity of an unladen swallow?");

static int AskForNumber(string text)
{
    Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}