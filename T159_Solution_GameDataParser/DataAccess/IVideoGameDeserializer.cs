using T159_Solution_GameDataParser.Model;

namespace T159_Solution_GameDataParser.DataAccess;

public interface IVideoGameDeserializer
{
	List<VideoGame>? DeserializeFrom(string fileName, string fileContents);
}