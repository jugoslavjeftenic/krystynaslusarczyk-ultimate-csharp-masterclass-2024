using T157_Assignment_GameDataParser.App;
using T157_Assignment_GameDataParser.Games;

var gameDataParserApp = new GameDataParserApp
	(
		new ConsoleAppUserInteraction(),
		new GamesRepository()
	);

try
{
	gameDataParserApp.Run();
}
catch (Exception)
{
	Console.WriteLine(
		"Sorry! The application has experienced an unexpected error and will have to be closed.");

	throw;
}

GameDataParserApp.Exit();
