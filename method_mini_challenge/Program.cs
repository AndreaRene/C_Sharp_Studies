Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay()) 
{
    PlayGame();
}

bool ShouldPlay()
{
    string response = Console.ReadLine();
    return response.ToLower().Equals("y");
}



void PlayGame() 
{
    var play = true;

    while (play) 
    {
        var target = TargetRoll();
        var roll = PlayerRoll();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(roll, target));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

int TargetRoll()
{
    return random.Next(1, 6);
}
int PlayerRoll()
{
    return random.Next(1, 7);
}

string WinOrLose(int roll, int target)
{
    if (roll > target)
    {
        return "You Win!";
    }
    return "You lose!";
}