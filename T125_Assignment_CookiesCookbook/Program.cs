using T125_Assignment_CookiesCookbook.Models;
using T125_Assignment_CookiesCookbook.Repositories;

List<IngredientModel> ingredients = IngredientsRepository.PopulateIngredients();
List<IngredientModel> ingredientsForRecipe = [];

Console.WriteLine("Create a new cookie recipe! Available ingredients are:");
IngredientsRepository.PrintIngredientsToConsoleMenu(ingredients);

while (true)
{
	Console.WriteLine("Add an ingredient by its ID or type anything else if finished.");
	if (int.TryParse(Console.ReadLine(), out var ingredientId))
	{
		// Check if ingredient choice is Ok and add to recipe
		IngredientModel? addIngredientToRecipe = IngredientsRepository.FindIngredient(ingredientId, ingredients);
		if (addIngredientToRecipe is not null)
		{
			ingredientsForRecipe.Add(addIngredientToRecipe);
		}
		// else continue loop
	}
	else if (ingredientsForRecipe.Count.Equals(0))
	{
		// Exit app without recipe
		Console.WriteLine("No ingredients have been selected. Recipe will not be saved.");
		break;
	}
	else
	{
		// make recipe and save to file and other stuff before ending app
		Console.WriteLine("(TODO) Make recipe.");
		break;
	}
}

