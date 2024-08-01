public abstract class Game
{
    protected string Name { get; init; }
    protected int CountGuesses { get; set; }
    public abstract void Start();
}