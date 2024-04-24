namespace T125_Assignment_CookiesCookbook.Models
{
	public class RecipeModel(List<IngredientModel> ingredients)
	{
		public List<int> Ingredients { get; set; } = ingredients.Select(ingredient => ingredient.ID).ToList();
	}
}
