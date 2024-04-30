using T127_Solution_CookiesCookbook.Recipes.Ingredients;

namespace T127_Solution_CookiesCookbook
{
	public interface IIngredientsRegister
	{
		IEnumerable<Ingredient> All { get; }
		Ingredient? GetById(int id);
	}
}