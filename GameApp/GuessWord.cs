namespace Games;

public class GuessWord : Game
{
    private int CountGuesses { get; set; }
    private string WordToGuess { get; init; }
    public override string Name { get; init; }
    public override string Description { get; init; }
    public GuessWord(string name = "GuessWord", string description = "Guess the word")
    {
        string[] words = ["csharp", "java", "rust", "js", "go", "c", "python"];
        WordToGuess = words[new Random().Next(words.Length)];
        CountGuesses = 0;
        Name = name;
        Description = description;
    }

    public override void Play()
    {
        string word;
        do
        {
            Write("Guess the word: ");
            word = ReadLine()!.ToLower();
            IncrementGuess();
            if (word == WordToGuess)
                WriteLine($"You guessed right in {CountGuesses} guesses.");
        } while (word != WordToGuess);
    }

    private void IncrementGuess() => CountGuesses++;
}