using T127_Solution_CookiesCookbook.Recipes;

namespace T127_Solution_CookiesCookbook.Repositories
{
	public interface IRecipesRepository
	{
		List<Recipe> Read(string filePath);
		void Write(string filePath, List<Recipe> allRecipes);
	}
}