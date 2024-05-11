using T157_Assignment_GameDataParser.App;
using T157_Assignment_GameDataParser.Games;

var gameDataParserApp = new GameDataParserApp
	(
		new ConsoleAppUserInteraction(),
		new GamesRepository()
	);

gameDataParserApp.Run();

GameDataParserApp.Exit();
