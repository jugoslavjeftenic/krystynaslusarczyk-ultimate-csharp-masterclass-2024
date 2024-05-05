namespace T157_Assignment_GameDataParser.App
{
	public class ConsoleAppUserInteraction : IAppUserInteraction
	{
		public string ReadFileNameFromUser()
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

				if (filePath == string.Empty)
				{
					Console.WriteLine("File name cannot be empty.");
					continue;
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
}
