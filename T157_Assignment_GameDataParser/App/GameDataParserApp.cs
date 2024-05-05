namespace T157_Assignment_GameDataParser.App;

public class GameDataParserApp(IAppUserInteraction appUserInteraction)
{
	private readonly IAppUserInteraction _appUserInteraction = appUserInteraction;

	public void Run()
	{
		string fileName = _appUserInteraction.ReadFileNameFromUser();

        Console.WriteLine($"Test imena datoteke: {fileName}");
    }

	public static void Exit()
	{
		Console.WriteLine("Press any key to close.");
	}
}
