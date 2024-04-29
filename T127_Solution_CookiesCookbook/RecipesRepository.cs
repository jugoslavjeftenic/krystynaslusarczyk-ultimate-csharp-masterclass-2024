using T127_Solution_CookiesCookbook.Recipes;
using T127_Solution_CookiesCookbook.Recipes.Ingredients;

namespace T127_Solution_CookiesCookbook
{
	public class RecipesRepository : IRecipesRepository
	{
		public List<Recipe> Read(string filePath)
		{
			return
			[
				new(
				[
					new WheatFlour(),
					new Butter(),
					new Sugar()
				]),
				new(
				[
					new CocoaPowder(),
					new SpeltFlour(),
					new Cinnamon()
				])
			];
		}
	}
}