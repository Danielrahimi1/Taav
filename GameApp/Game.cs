namespace Games;

public abstract class Game
{
    public abstract string Name { get; init; }
    public virtual string Description { get; init; } = "";
    public abstract void Play();
}