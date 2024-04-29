namespace T127_Solution_CookiesCookbook.Recipes.Ingredients
{
	public abstract class Flour : Ingredient
	{
		public override string PreparationInstructions => $"Sieve. {base.PreparationInstructions}";
	}
}