using T125_Assignment_CookiesCookbook;
using T125_Assignment_CookiesCookbook.Extensions;
using T125_Assignment_CookiesCookbook.Models;
using T125_Assignment_CookiesCookbook.Repositories;

// File format setup
const string FileName = "recipes";
const FileExtension FileExtension = FileExtension.Txt;

List<RecipeModel> recipes = [];
List<IngredientModel> ingredientsRepository = IngredientsRepository.PopulateIngredients();
List<IngredientModel> newRecipeIngredients = [];

// Print existing recipes
recipes.ReadExistingRecipes(FileName, FileExtension.ToString(), ingredientsRepository);
recipes.PrintExistingRecipes();

Console.WriteLine("Create a new cookie recipe! Available ingredients are:");
IngredientsRepository.PrintIngredientsFromRepository(ingredientsRepository);

while (true)
{
	Console.WriteLine("Add an ingredient by its ID or type anything else if finished.");
	if (int.TryParse(Console.ReadLine(), out var ingredientId))
	{
		// Check if ingredient choice is Ok and add to recipe
		IngredientModel? ingredientToAdd =
			IngredientsRepository.FindIngredient(ingredientId, ingredientsRepository);
		if (ingredientToAdd is not null)
		{
			newRecipeIngredients.Add(ingredientToAdd);
		}
		// else continue loop
	}
	else if (newRecipeIngredients.Count.Equals(0))
	{
		// Exit app if no ingredient in recipe
		Console.WriteLine("No ingredients have been selected. Recipe will not be saved.");
		break;
	}
	else
	{
		// Print newly created recipe to console and save recipes to file
		Console.WriteLine("Recipe added:");
		recipes.Add(new RecipeModel(newRecipeIngredients));
		recipes.PrintLastRecipeIngredients();
		recipes.SaveRecipes(FileName, FileExtension.ToString());
		break;
	}
}

