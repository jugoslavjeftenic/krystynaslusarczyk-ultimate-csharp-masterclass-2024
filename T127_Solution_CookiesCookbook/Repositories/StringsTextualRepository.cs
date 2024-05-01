namespace T127_Solution_CookiesCookbook.Repositories
{
	public class StringsTextualRepository : StringsRepository
	{
		private static readonly string _separator = Environment.NewLine;

		protected override List<string> TextToStrings(string fileContents)
		{
			return [.. fileContents.Split(_separator)];
		}

		protected override string? StringsToText(List<string> strings)
		{
			return string.Join(_separator, strings);
		}
	}
}
