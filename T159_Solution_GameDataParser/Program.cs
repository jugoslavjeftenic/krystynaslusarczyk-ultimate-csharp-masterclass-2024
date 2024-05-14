using System.Text.Json;

var app = new GameDataParserApp();
var logger = new Logger("log.txt");

try
{
	app.Run();
}
catch (Exception ex)
{
	Console.WriteLine(
		"Sorry! The application has experienced an unexpected error and will have to be closed.");
	logger.Log(ex);
}

Console.WriteLine("Press any key to close.");

public class GameDataParserApp
{
	public void Run()
	{
		string fileName;
		string fileContents = string.Empty;
		bool isFileRead = false;
		do
		{
			Console.WriteLine("Enter the name of the file you want to read:");
			fileName = Console.ReadLine() ?? string.Empty;

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

			if (fileName is null)
			{
				Console.WriteLine("File name cannot be null.");
			}
			else if (fileName.Equals(string.Empty))
			{
				Console.WriteLine("File name cannot be empty.");
			}
			else if (File.Exists(fileName) is false)
			{
				Console.WriteLine("File not found.");
			}
			else
			{
				fileContents = File.ReadAllText(fileName);
				isFileRead = true;
			}
		} while (isFileRead is false);

		List<VideoGame>? videoGames = default;
		try
		{
			videoGames = JsonSerializer.Deserialize<List<VideoGame>>(fileContents);
		}
		catch (JsonException ex)
		{
			var originalColor = Console.ForegroundColor;
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine($"JSON in the {fileName} was not in a valid format. JSON body:");
			Console.WriteLine(fileContents);
			Console.ForegroundColor = originalColor;

			throw new JsonException($"{ex.Message} The file is: {fileName}", ex);
		}

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
	}
}


public class VideoGame
{
	public string Title { get; init; } = string.Empty;
	public int ReleaseYear { get; init; }
	public decimal Rating { get; init; }

	public override string ToString() => $"{Title}, released in {ReleaseYear}, rating {Rating}";
}