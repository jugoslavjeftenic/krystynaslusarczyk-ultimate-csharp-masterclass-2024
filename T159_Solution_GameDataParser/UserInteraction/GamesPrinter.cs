using T159_Solution_GameDataParser.Model;

namespace T159_Solution_GameDataParser.UserInteraction;

public class GamesPrinter(IUserInteractor userInteractor) : IGamesPrinter
{
	private readonly IUserInteractor _userInteractor = userInteractor;

	public void Print(List<VideoGame> videoGames)
	{
		if (videoGames.Count > 0)
		{
			_userInteractor.PrintMessage(Environment.NewLine);
			_userInteractor.PrintMessage("Loaded games are:");

			foreach (var videoGame in videoGames)
			{
				_userInteractor.PrintMessage(videoGame.ToString());
			}
		}
		else
		{
			_userInteractor.PrintMessage("No games are present in the input file.");
		}
	}
}