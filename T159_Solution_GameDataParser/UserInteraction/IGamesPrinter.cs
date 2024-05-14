using T159_Solution_GameDataParser.Model;

namespace T159_Solution_GameDataParser.UserInteraction;

public interface IGamesPrinter
{
	void Print(List<VideoGame> videoGames);
}