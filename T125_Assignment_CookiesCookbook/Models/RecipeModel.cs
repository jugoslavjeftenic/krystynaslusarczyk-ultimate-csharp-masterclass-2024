namespace T125_Assignment_CookiesCookbook.Models
{
	public class RecipeModel(List<IngredientModel> ingredients)
	{
		public List<IngredientModel> Ingredients { get; set; } = ingredients;

		public override string ToString()
		{
			string returnString = string.Empty;

			foreach (var ingredient in Ingredients)
			{
				returnString += $"{ingredient.Name}. {ingredient.PreparationInstructions}" +
					Environment.NewLine;
			}

			return returnString;
		}
	}
}
