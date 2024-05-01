using T127_Solution_CookiesCookbook.Recipes;
using T127_Solution_CookiesCookbook.Recipes.Ingredients;

namespace T127_Solution_CookiesCookbook.App;

public class RecipesConsoleUserInteraction(IIngredientsRegister ingredientsRegister) : IRecipesUserInteraction
{
	private readonly IIngredientsRegister _ingredientsRegister = ingredientsRegister;

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

	public IEnumerable<Ingredient> ReadIngredientsFromUser()
	{
		bool shallStop = false;
		var ingredients = new List<Ingredient>();

		while (shallStop is false)
		{
			Console.WriteLine("Add an ingredient by it's ID, or type anything else if finished.");
			var userInput = Console.ReadLine();

			if (int.TryParse(userInput, out int id))
			{
				var selectedIngredient = _ingredientsRegister.GetById(id);
				if (selectedIngredient is not null)
				{
					ingredients.Add(selectedIngredient);
				}
			}
			else
			{
				shallStop = true;
			}
		}

		return ingredients;
	}

	public void Exit()
	{
		Console.WriteLine("Press any key to close.");
		Console.ReadKey();
	}
}