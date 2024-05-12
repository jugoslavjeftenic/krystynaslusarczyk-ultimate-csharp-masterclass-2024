using T157_Assignment_GameDataParser.App;
using T157_Assignment_GameDataParser.Games;
using T157_Assignment_GameDataParser.Logging;

var gameDataParserApp = new GameDataParserApp
	(
		new ConsoleAppUserInteraction(),
		new GamesRepository()
	);

try
{
	gameDataParserApp.Run();
}
catch (Exception ex)
{
	Console.WriteLine(
		"Sorry! The application has experienced an unexpected error and will have to be closed.");

	Logger.Log(ex);
}

GameDataParserApp.Exit();
