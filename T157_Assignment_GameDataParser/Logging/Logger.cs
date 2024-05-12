namespace T157_Assignment_GameDataParser.Logging;

public class Logger
{
	public static void Log(Exception ex)
	{
		string stringToLog;
		stringToLog = $"[{DateTime.Now}]";
		stringToLog += Environment.NewLine;

		stringToLog += "Exception message:";
		stringToLog += ex.Message;
		stringToLog += Environment.NewLine;

		stringToLog += "Stack trace:";
		stringToLog += ex.StackTrace;
		stringToLog += Environment.NewLine;
		stringToLog += Environment.NewLine;

		using StreamWriter writeText = new("log.txt", true);
		writeText.Write(stringToLog);
	}
}
