using Games;

namespace Gamenet;
public class GameNet
{
    private string _player;
    private List<Game> _games;

    // To be implemented
    // Params Collection
    // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/params-collections
    public GameNet(string player, List<Game> games = null)
    {
        _player = player;
        _games = games;
        _games ??= [];
    }

    public void AddGame(Game game)
    {
        _games.Add(game);
    }

    public void ComeIn()
    {
        WriteLine($"Welcome, Dear {_player}.");
        ShowGames();
        Write($"Select a game: ");
        PlayGame(GetChoice());
    }

    private void PlayGame(int id)
    {
        var game = _games[id - 1];
        WriteLine($"Welcome {_player}. Enjoy the {game.Name}.");
        game.Play();
    }

    private void ShowGames()
    {
        for (int i = 0; i < _games.Count; i++)
        {
            WriteLine($"{i + 1}. {_games[i].Name} - {_games[i].Description}");
        }
        WriteLine($"-1. Exit");
    }

    private int GetChoice()
    {
        while (true)
        {
            if (int.TryParse(ReadLine()!, out int userInput))
            {
                if (userInput == -1) Environment.Exit(0);
                if (1 <= userInput && userInput <= _games.Count) return userInput;
            }
        }
    }
}
