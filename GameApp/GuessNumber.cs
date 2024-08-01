using static System.Console;

namespace Games;

public class GuessNumber : Game
{
    private int NumberToGuess { get; init; }
    public GuessNumber()
    {
        NumberToGuess = new Random().Next(1, 101);
        CountGuesses = 0;
        Name = "GuessNumber";
    }


    private void Play()
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

    public override void Start()
    {
        Play();
    }
}