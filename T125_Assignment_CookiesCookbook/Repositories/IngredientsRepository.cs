using T125_Assignment_CookiesCookbook.Models;

namespace T125_Assignment_CookiesCookbook.Repositories
{
	public class IngredientsRepository
	{
		public static List<IngredientModel> PopulateIngredients()
		{
			return
			[
				new IngredientModel()
				{
					ID = 1,
					Name = "Wheat flour",
					PreparationInstructions = "Sieve. Add to other ingredients."
				},
				new IngredientModel()
				{
					ID = 2,
					Name = "Coconut flour",
					PreparationInstructions = "Sieve. Add to other ingredients."
				},
				new IngredientModel()
				{
					ID = 3,
					Name = "Butter",
					PreparationInstructions = "Melt on low heat. Add to other ingredients."
				},
				new IngredientModel(){
					ID = 4,
					Name = "Chocolate",
					PreparationInstructions = "Melt in a water bath. Add to other ingredients."
				},
				new IngredientModel()
				{
					ID = 5,
					Name = "Sugar",
					PreparationInstructions = "Add to other ingredients."
				},
				new IngredientModel(){
					ID = 6,
					Name = "Cardamom",
					PreparationInstructions = "Take half a teaspoon. Add to other ingredients."
				},
				new IngredientModel()
				{
					ID = 7,
					Name = "Cinnamon",
					PreparationInstructions = "Take half a teaspoon. Add to other ingredients."
				},
				new IngredientModel()
				{
					ID = 8,
					Name = "Cocoa powder",
					PreparationInstructions = "Add to other ingredients."
				},
			];
		}

		public static void PrintIngredientsFromRepository(List<IngredientModel> ingredients)
		{
			foreach (var ingredient in ingredients)
			{
				Console.WriteLine($"{ingredient.ID}. {ingredient.Name}");
			}
		}

		public static IngredientModel? FindIngredient(int id, List<IngredientModel> ingredients)
		{
			return ingredients.Find(x => x.ID == id);
		}
	}
}
