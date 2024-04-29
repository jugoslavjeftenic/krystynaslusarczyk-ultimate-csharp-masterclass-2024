using T127_Solution_CookiesCookbook.Recipes;

namespace T127_Solution_CookiesCookbook
{
	public interface IRecipesRepository
	{
		List<Recipe> Read(string filePath);
	}
}