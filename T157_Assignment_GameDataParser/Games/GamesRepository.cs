using System.Text.Json;

namespace T157_Assignment_GameDataParser.Games;

public class GamesRepository : IGamesRepository
{
	public List<GameModel> ReadGamesFromJson(string filePath)
	{
		if (File.Exists(filePath))
		{
			var fileContent = File.ReadAllText(filePath);
			return JsonSerializer.Deserialize<List<GameModel>>(fileContent) ?? [];
		}

		return [];
	}
}
