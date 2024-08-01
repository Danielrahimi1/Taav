using static System.Console;
using Games;
namespace Gamenet;
public class GameNet
{
    public Game ObjGame { get; set; }

    public void Play()
    {
        Buy();
        ObjGame.Start();
    }
    private void Buy()
    {
        while (true)
        {
            WriteLine("1. GuessNumber\n2. GuessWord\n3. Exit");
            switch (ReadLine())
            {
                case "1": ObjGame = new GuessNumber(); return;
                case "2": ObjGame = new GuessWord(); return;
                case "3": Environment.Exit(0); return;
            }
        }
    }
}