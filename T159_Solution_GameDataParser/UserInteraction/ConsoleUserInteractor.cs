namespace T159_Solution_GameDataParser.UserInteraction;

public class ConsoleUserInteractor : IUserInteractor
{
	public string ReadValidFilePath()
	{
		string fileName;
		bool isFilePathValid = false;

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
				isFilePathValid = true;
			}
		} while (isFilePathValid is false);

		return fileName!;
	}

	public void PrintMessage(string message)
	{
		Console.WriteLine(message);
	}

	public void PrintError(string message)
	{
		var originalColor = Console.ForegroundColor;
		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine(message);
		Console.ForegroundColor = originalColor;
	}
}