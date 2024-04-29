using T127_Solution_CookiesCookbook.Recipes.Ingredients;

namespace T127_Solution_CookiesCookbook.Recipes
{
    public class Recipe(IEnumerable<Ingredient> ingredients)
	{
		public IEnumerable<Ingredient> Ingredients { get; } = ingredients;
	}
}