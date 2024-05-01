using T127_Solution_CookiesCookbook.Recipes.Ingredients;

namespace T127_Solution_CookiesCookbook.Recipes;

public class Recipe(IEnumerable<Ingredient> ingredients)
{
	public IEnumerable<Ingredient> Ingredients { get; } = ingredients;

	public override string ToString()
	{
		var steps = new List<string>();
		foreach (var ingredient in Ingredients)
		{
			steps.Add($"{ingredient.Name}. {ingredient.PreparationInstructions}");
		}

		return string.Join(Environment.NewLine, steps);
	}
}