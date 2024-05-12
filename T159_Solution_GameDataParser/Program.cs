using System.Text.Json;

string fileContents = string.Empty;
bool isFileRead = false;

do
{
	try
	{
		Console.WriteLine("Enter the name of the file you want to read:");
		var fileName = Console.ReadLine() ?? string.Empty;

		if (fileName.Equals("1"))
		{
			fileName = "games.json";
		}
		if (fileName.Equals("2"))
		{
			fileName = "gamesEmpty.json";
		}
		if (fileName.Equals("3"))
		{
			fileName = "gamesInvalidFormat.json";
		}

		fileContents = File.ReadAllText(fileName);
		isFileRead = true;
	}
	catch (ArgumentNullException)
	{
		Console.WriteLine("File name cannot be null.");
	}
	catch (ArgumentException)
	{
		Console.WriteLine("File name cannot be empty.");
	}
	catch (FileNotFoundException)
	{
		Console.WriteLine("File not found.");
	}
} while (isFileRead is false);

var videoGames = JsonSerializer.Deserialize<List<VideoGame>>(fileContents);

if (videoGames?.Count > 0)
{
	Console.WriteLine();
	Console.WriteLine("Loaded games are:");

	foreach (var videoGame in videoGames)
	{
		Console.WriteLine(videoGame);
	}
}
else
{
	Console.WriteLine("No games are present in the input file.");
}

public class VideoGame
{
	public string Title { get; init; } = string.Empty;
	public int ReleaseYear { get; init; }
	public decimal Rating { get; init; }

	public override string ToString() => $"{Title}, released in {ReleaseYear}, rating {Rating}";
}