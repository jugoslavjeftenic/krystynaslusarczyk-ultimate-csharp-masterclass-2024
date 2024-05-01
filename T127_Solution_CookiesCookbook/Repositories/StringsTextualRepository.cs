namespace T127_Solution_CookiesCookbook.Repositories
{
	public class StringsTextualRepository : IStringsRepository
	{
		private static readonly string _separator = Environment.NewLine;

		public List<string> Read(string filePath)
		{
			if (File.Exists(filePath))
			{
				var fileContents = File.ReadAllText(filePath);
				return [.. fileContents.Split(_separator)];
			}

			return [];
		}

		public void Write(string filePath, List<string> strings)
		{
			File.WriteAllText(filePath, string.Join(_separator, strings));
		}
	}
}
