namespace T127_Solution_CookiesCookbook.Recipes.Ingredients;

public interface IIngredientsRegister
{
	IEnumerable<Ingredient> All { get; }
	Ingredient? GetById(int id);
}