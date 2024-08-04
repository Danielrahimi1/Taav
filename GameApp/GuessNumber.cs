namespace Games;

public class GuessNumber : Game
{
    private int NumberToGuess { get; init; }
    private int _countGuesses { get; set; }
    public override string Name { get; init; }
    public override string Description { get; init; }
    public GuessNumber(string name = "GuessNumber", string description = "Guess number between 1 and 100")
    {
        Name = name;
        Description = description;
        _countGuesses = 0;
        NumberToGuess = new Random().Next(1, 101);
    }


    public override void Play()
    {
        int num;
        do
        {
            num = GetNum();
            IncrementGuess();
            string msg = num switch
            {
                int x when x > NumberToGuess => "You guessed bigger.",
                int x when x < NumberToGuess => "You guessed smaller.",
                _ => $"You guessed right in {_countGuesses} guesses."
            };
            WriteLine(msg);
        } while (num != NumberToGuess);
    }

    private void IncrementGuess() => _countGuesses++;
    private static int GetNum()
    {
        while (true)
        {
            Write("Guess a number : ");
            if (int.TryParse(ReadLine(), out int num)) return num;
        }
    }
}