using System.Text.Json;

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
		catch (JsonException)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine($"JSON in the {filePath} was not in a valid format. JSON body:");

			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(fileContent);

			throw;
		}
	}
}
