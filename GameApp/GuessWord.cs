using static System.Console;

namespace Games;

public class GuessWord : Game
{
    private string WordToGuess { get; init; }
    public GuessWord()
    {
        string[] words = ["csharp", "java", "rust", "js", "go", "c", "python"];
        WordToGuess = words[new Random().Next(words.Length)];
        CountGuesses = 0;
        Name = "GuessWord";
    }

    private void Play()
    {
        string word;
        do
        {
            word = ReadLine()!.ToLower();
            IncrementGuess();
            if (word == WordToGuess)
                WriteLine($"You guessed right in {CountGuesses} guesses.");
        } while (word != WordToGuess);
    }

    private void IncrementGuess() => CountGuesses++;

    public override void Start()
    {
        Play();
    }
}