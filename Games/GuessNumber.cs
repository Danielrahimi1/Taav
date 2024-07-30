using static System.Console;
public class GuessNumber
{
    private readonly Random _random;
    private int NumberToGuess { get; set; }
    private int CountGuesses { get; set; }
    private void IncrementGuess() => CountGuesses += 1;
    public GuessNumber()
    {
        _random = new Random();
        NumberToGuess = _random.Next(1, 101);
        CountGuesses = 0;
    }

    public void Play()
    {
        string guess = "";
        int num;
        while (guess != "equal")
        {
            num = GetNum();
            guess = Guess(num);

            if (guess == "equal")
                WriteLine($"You guessed right in {CountGuesses} guesses.");
            else
                WriteLine($"You guessed {guess}");
        }
    }

    private string Guess(int num)
    {
        IncrementGuess();

        if (num < NumberToGuess)
            return "smaller";
        if (num > NumberToGuess)
            return "bigger";
        return "equal";
    }

    private static int GetNum()
    {
        string str;
        while (true)
        {
            Write("Guess a number : ");
            str = ReadLine()!;
            if (int.TryParse(str, out int num)) return num;
        }
    }

}