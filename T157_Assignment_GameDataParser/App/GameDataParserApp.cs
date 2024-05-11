using T157_Assignment_GameDataParser.Games;

namespace T157_Assignment_GameDataParser.App;

public class GameDataParserApp(IAppUserInteraction appUserInteraction, IGamesRepository gamesRepository)
{
	private readonly IAppUserInteraction _appUserInteraction = appUserInteraction;
	private readonly IGamesRepository _gamesRepository = gamesRepository;

	public void Run()
	{
		string filePath = _appUserInteraction.ReadAndValidateFilePathFromUser();
		List<GameModel> games = _gamesRepository.ReadGamesFromJson(filePath);

		foreach (var game in games)
		{
			Console.WriteLine(game.Title);
		}
	}

	public static void Exit()
	{
		Console.WriteLine("Press any key to close.");
	}
}
