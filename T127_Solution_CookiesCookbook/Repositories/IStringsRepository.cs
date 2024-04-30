
namespace T127_Solution_CookiesCookbook.Repositories
{
	public interface IStringsRepository
	{
		List<string> Read(string filePath);
		void Write(string filePath, List<string> strings);
	}
}