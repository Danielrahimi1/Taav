using Games;

namespace Gamenet;
public class GameNet //(string player, params Game[] games)
{
    // private List<Game> _games;
    private string _player;
    private List<Game> _games = [];
    public GameNet(string player) //, params Game[] games)
    {
        _player = player;
        // _games = games;
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
            Console.WriteLine($"{i + 1}. {_games[i].Name} - {_games[i].Description}");
        }
    }

    private int GetChoice()
    {
        while (true)
        {
            if (int.TryParse(ReadLine()!, out int userInput))
            {
                if (1 <= userInput && userInput <= _games.Count)
                {
                    return userInput;
                }
            }
        }
    }
}
