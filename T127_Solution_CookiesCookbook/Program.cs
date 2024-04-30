using T127_Solution_CookiesCookbook;

var cookiesRecipesApp = new CookiesRecipesApp
	(
		new RecipesRepository(),
		new RecipesConsoleUserInteraction(new IngredientsRegister())
	);

cookiesRecipesApp.Run("recipes.txt");
