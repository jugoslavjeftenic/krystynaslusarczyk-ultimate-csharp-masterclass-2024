namespace T157_Assignment_GameDataParser.Games;

public static class GamesExtensions
{
	public static void PrintToConsole(this List<GameModel> games)
	{
		if (games.Count>0)
		{
			Console.WriteLine("Loaded games are:");

			foreach (var game in games)
			{
				Console.WriteLine(game.ToString());
			}
		}
		else
		{
			Console.WriteLine("No games are present in the input file.");
		}
	}
}
