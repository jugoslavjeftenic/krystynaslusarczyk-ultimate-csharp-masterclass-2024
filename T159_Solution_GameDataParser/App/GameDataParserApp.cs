using T159_Solution_GameDataParser.DataAccess;
using T159_Solution_GameDataParser.UserInteraction;

namespace T159_Solution_GameDataParser.App;

public class GameDataParserApp(
	IUserInteractor userInteractor,
	IGamesPrinter gamesPrinter,
	IVideoGameDeserializer videoGameDeserializer,
	IFileReader fileReader
)
{
	private readonly IUserInteractor _userInteractor = userInteractor;
	private readonly IGamesPrinter _gamesPrinter = gamesPrinter;
	private readonly IVideoGameDeserializer _videoGameDeserializer = videoGameDeserializer;
	private readonly IFileReader _fileReader = fileReader;

	public void Run()
	{
		var fileName = _userInteractor.ReadValidFilePath();
		var fileContents = _fileReader.Read(fileName);
		var videoGames = _videoGameDeserializer.DeserializeFrom(fileName, fileContents);

		_gamesPrinter.Print(videoGames!);
	}
}