using T127_Solution_CookiesCookbook.Recipes;
using T127_Solution_CookiesCookbook.Recipes.Ingredients;

namespace T127_Solution_CookiesCookbook.App;

public interface IRecipesUserInteraction
{
	void ShowMessage(string message);
	void PrintExistingRecipes(IEnumerable<Recipe> allRecipes);
	void PromptToCreateRecipe();
	IEnumerable<Ingredient> ReadIngredientsFromUser();
	void Exit();
}