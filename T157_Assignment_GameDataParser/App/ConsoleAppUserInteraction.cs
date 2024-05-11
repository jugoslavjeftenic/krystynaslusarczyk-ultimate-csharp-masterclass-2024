namespace T157_Assignment_GameDataParser.App;

public class ConsoleAppUserInteraction : IAppUserInteraction
{
	public string ReadAndValidateFilePathFromUser()
	{
		string? filePath;

		while (true)
		{
			Console.WriteLine("Enter the name of the file you want to read:");
			filePath = Console.ReadLine();

			if (filePath is null)
			{
				Console.WriteLine("File name cannot be null.");
				continue;
			}

			if (filePath.Equals(string.Empty))
			{
				Console.WriteLine("File name cannot be empty.");
				continue;
			}

			if (filePath.Equals("1"))
			{
				filePath = "games.json";
			}

			if (filePath.Equals("2"))
			{
				filePath = "gamesEmpty.json";
			}

			if (filePath.Equals("3"))
			{
				filePath = "gamesInvalidFormat.json";
			}

			if (File.Exists(filePath) is false)
			{
				Console.WriteLine("File not found.");
				continue;
			}

			return filePath;
		}
	}
}
