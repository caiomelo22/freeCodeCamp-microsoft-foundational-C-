Random random = new Random();

int generateRandomInt(int startRange, int endRange)
{
    return random.Next(startRange, endRange + 1);
}

bool ShouldPlay()
{
    string? readResult;
    string decision = "";

    do
    {
        readResult = Console.ReadLine();
        if (readResult != null)
        {
            decision = readResult.ToLower();
        }

        if (decision == "y" || decision == "n")
            return decision == "y";
    } while (true);
}

string WinOrLose(int roll, int target)
{
    if (roll > target)
        return "You win!";
    else
        return "You lose!";
}

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay())
{
    PlayGame();
}

void PlayGame()
{
    var play = true;

    while (play)
    {
        var target = generateRandomInt(1, 5);
        var roll = generateRandomInt(1, 6);

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(roll, target));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}