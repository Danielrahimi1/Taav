using static System.Console;
public class GuessNumber
{
    private int NumberToGuess { get; init; }
    private int CountGuesses { get; set; }
    public GuessNumber()
    {
        NumberToGuess = new Random().Next(1, 101);
        CountGuesses = 0;
    }

    public void Play()
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
                _ => $"You guessed right in {CountGuesses} guesses."
            };
            WriteLine(msg);
        } while (num != NumberToGuess);
    }

    private void IncrementGuess() => CountGuesses++;
    private static int GetNum()
    {
        while (true)
        {
            Write("Guess a number : ");
            if (int.TryParse(ReadLine(), out int num)) return num;
        }
    }
}