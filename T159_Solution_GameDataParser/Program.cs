using T159_Solution_GameDataParser.App;
using T159_Solution_GameDataParser.DataAccess;
using T159_Solution_GameDataParser.Logging;
using T159_Solution_GameDataParser.UserInteraction;

var userInteractor = new ConsoleUserInteractor();
var app = new GameDataParserApp(
	userInteractor,
	new GamesPrinter(userInteractor),
	new VideoGameDeserializer(userInteractor),
	new LocalFileReader()
);
var logger = new Logger("log.txt");

try
{
	app.Run();
}
catch (Exception ex)
{
	Console.WriteLine(
		"Sorry! The application has experienced an unexpected error and will have to be closed.");
	logger.Log(ex);
}

Console.WriteLine("Press any key to close.");
