namespace T127_Solution_CookiesCookbook.Recipes.Ingredients;

public abstract class Spice : Ingredient
{
	public override string PreparationInstructions => $"Melt in a water bath. {base.PreparationInstructions}";
}