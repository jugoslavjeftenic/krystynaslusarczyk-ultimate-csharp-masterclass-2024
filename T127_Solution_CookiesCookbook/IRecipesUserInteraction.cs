using T127_Solution_CookiesCookbook.Recipes;

namespace T127_Solution_CookiesCookbook
{
	public interface IRecipesUserInteraction
	{
		void ShowMessage(string message);
		void PrintExistingRecipes(IEnumerable<Recipe> allRecipes);
		void PromptToCreateRecipe();
		void Exit();
	}
}