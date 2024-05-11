namespace T157_Assignment_GameDataParser.Games
{
	public interface IGamesRepository
	{
		List<GameModel> ReadGamesFromJson(string filePath);
	}
}