namespace T127_Solution_CookiesCookbook.Recipes;

public interface IRecipesRepository
{
	List<Recipe> Read(string filePath);
	void Write(string filePath, List<Recipe> allRecipes);
}