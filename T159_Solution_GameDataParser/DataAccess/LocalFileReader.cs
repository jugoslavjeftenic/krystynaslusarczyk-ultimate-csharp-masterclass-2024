namespace T159_Solution_GameDataParser.DataAccess;

public class LocalFileReader : IFileReader
{
	public string Read(string fileName)
	{
		return File.ReadAllText(fileName);
	}
}