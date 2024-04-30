using T127_Solution_CookiesCookbook.Recipes;

namespace T127_Solution_CookiesCookbook
{
	public class RecipesConsoleUserInteraction(IngredientsRegister ingredientsRegister) : IRecipesUserInteraction
	{
		private readonly IngredientsRegister _ingredientsRegister = ingredientsRegister;

		public void ShowMessage(string message)
		{
			Console.WriteLine(message);
		}

		public void PrintExistingRecipes(IEnumerable<Recipe> allRecipes)
		{
			if (allRecipes.Any())
			{
				Console.WriteLine("Existing recipes are:" + Environment.NewLine);

				var counter = 1;
				foreach (var recipe in allRecipes)
				{
					Console.WriteLine($"***** {counter} *****");
					Console.WriteLine(recipe);
					Console.WriteLine();
					counter++;
				}
			}
		}

		public void PromptToCreateRecipe()
		{
			Console.WriteLine("Create a new cookie recipe! Available ingredients are:");

			foreach (var ingredient in _ingredientsRegister.All)
			{
				Console.WriteLine(ingredient);
			}
		}

		public void Exit()
		{
			Console.WriteLine("Press any key to close.");
			Console.ReadKey();
		}
	}
}