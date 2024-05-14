using System.Text.Json;
using T159_Solution_GameDataParser.Model;
using T159_Solution_GameDataParser.UserInteraction;

namespace T159_Solution_GameDataParser.DataAccess;

public class VideoGameDeserializer(IUserInteractor userInteractor) : IVideoGameDeserializer
{
	private readonly IUserInteractor _userInteractor = userInteractor;

	public List<VideoGame>? DeserializeFrom(string fileName, string fileContents)
	{
		try
		{
			return JsonSerializer.Deserialize<List<VideoGame>>(fileContents);
		}
		catch (JsonException ex)
		{
			_userInteractor.PrintError($"JSON in the {fileName} was not in a valid format. JSON body:");
			_userInteractor.PrintError(fileContents);

			throw new JsonException($"{ex.Message} The file is: {fileName}", ex);
		}
	}
}