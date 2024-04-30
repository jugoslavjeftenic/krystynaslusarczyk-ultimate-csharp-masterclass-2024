using T127_Solution_CookiesCookbook;
using T127_Solution_CookiesCookbook.Repositories;

var ingredientsRegister = new IngredientsRegister();

var cookiesRecipesApp = new CookiesRecipesApp
	(
		new RecipesRepository(
			   new StringsTextualRepository(),
			   ingredientsRegister),
		new RecipesConsoleUserInteraction(ingredientsRegister)
	);

cookiesRecipesApp.Run("recipes.txt");
