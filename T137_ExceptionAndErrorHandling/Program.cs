var logger = new Logger();

try
{
	Run();
}
catch (Exception ex)
{
	Console.WriteLine("Sorry. The application has experienced an error." +
		$"The error message: {ex.Message}");
	logger.Log(ex);
}

void Run()
{
	try
	{
		Console.WriteLine("Enter a word:");
		var word = Console.ReadLine()!;
		Console.WriteLine($"Count of characters is: {word.Length}");
	}
	catch (NullReferenceException ex)
	{
		Console.WriteLine("The input is null, and its length cannot be calculated.");
		Console.WriteLine("Did you press CTRL+Z in the console?");
		logger.Log(ex);
		throw;
	}
}

public class Logger
{
	public void Log(Exception ex)
	{
		throw new NotImplementedException();
	}
}
