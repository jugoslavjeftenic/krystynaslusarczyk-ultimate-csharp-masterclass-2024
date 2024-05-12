using System.Text.Json;
using T157_Assignment_GameDataParser.Logging;

namespace T157_Assignment_GameDataParser.Games;

public class GamesRepository : IGamesRepository
{
	public List<GameModel> ReadGamesFromJson(string filePath)
	{
		var fileContent = File.ReadAllText(filePath);

		if (string.IsNullOrEmpty(fileContent))
		{
			return [];
		}

		try
		{
			return JsonSerializer.Deserialize<List<GameModel>>(fileContent) ?? [];
		}
		catch (JsonException ex)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine($"JSON in the {filePath} was not in a valid format. JSON body:");

			Console.WriteLine(fileContent);
			Console.ForegroundColor = ConsoleColor.White;

			Logger.Log(ex);
			throw;
		}
	}
}
