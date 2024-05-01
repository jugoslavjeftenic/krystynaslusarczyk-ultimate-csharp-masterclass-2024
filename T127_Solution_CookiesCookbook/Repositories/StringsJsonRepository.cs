using System.Text.Json;

namespace T127_Solution_CookiesCookbook.Repositories
{
	public class StringsJsonRepository : IStringsRepository
	{
		public List<string> Read(string filePath)
		{
			if (File.Exists(filePath))
			{
				var fileContents = File.ReadAllText(filePath);
				return JsonSerializer.Deserialize<List<string>>(fileContents)!;
			}

			return [];
		}

		public void Write(string filePath, List<string> strings)
		{
			File.WriteAllText(filePath, JsonSerializer.Serialize(strings));
		}
	}
}
