﻿namespace T127_Solution_CookiesCookbook
{
	public class CookiesRecipesApp
		(IRecipesRepository recipesRepository, IRecipesUserInteraction recipesUserInteraction)
	{
		private readonly IRecipesRepository _recipesRepository = recipesRepository;
		private readonly IRecipesUserInteraction _recipesUserInteraction = recipesUserInteraction;

		public void Run(string filePath)
		{
			var allRecipes = _recipesRepository.Read(filePath);
			_recipesUserInteraction.PrintExistingRecipes(allRecipes);

			_recipesUserInteraction.PromptToCreateRecipe();

			//var ingredients = _recipesUserInteraction.ReadIngredientsFromUser();

			//if (ingredients.Count > 0)
			//{
			//	var recipe = new Recipe(ingredients);
			//	allRecipes.Add(recipe);
			//	_recipesRepository.Write(filePath, allRecipes);

			//	_recipesUserInteraction.ShowMessage("Recipe added:");
			//	_recipesUserInteraction.ShowMessage(recipe.ToString());
			//}
			//else
			//{
			//	_recipesUserInteraction
			//		.ShowMessage("No ingredients have been selected. Recipe will not be saved.");
			//}

			_recipesUserInteraction.Exit();
		}
	}
}