
public class Logger(string logFileName)
{
	private readonly string _logFileName = logFileName;

	public void Log(Exception ex)
	{
		string entry;
		entry = $"[{DateTime.Now}]";
		entry += Environment.NewLine;

		entry += "Exception message:";
		entry += ex.Message;
		entry += Environment.NewLine;

		entry += "Stack trace:";
		entry += ex.StackTrace;
		entry += Environment.NewLine;
		entry += Environment.NewLine;

		File.AppendAllText(_logFileName, entry);
	}
}