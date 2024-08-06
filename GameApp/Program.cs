using Games;
using Gamenet;



var gameNet = new GameNet("John", new GuessNumber(),
    new GuessNumber(),
    new GuessNumber(),
    new GuessNumber(),
    new GuessNumber());

// gameNet.AddGame(new GuessNumber());
// gameNet.AddGame(new GuessNumber("Rockstar Guess Number"));
// gameNet.AddGame(new GuessNumber("Blizzard Guess Number"));
// gameNet.AddGame(new GuessNumber("CDPR Guess Number"));
// gameNet.AddGame(new GuessWord());
// gameNet.AddGame(new GuessWord("Ubisoft Guess Word"));
// gameNet.AddGame(new GuessWord("FromSoftware Guess Word"));
// gameNet.AddGame(new GuessWord("Bethesda Guess Word"));



gameNet.ComeIn();
