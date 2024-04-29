using T127_Solution_CookiesCookbook;

var cookiesRecipesApp = new CookiesRecipesApp
	(
		new RecipesRepository(),
		new RecipesConsoleUserInteraction()
	);

cookiesRecipesApp.Run();
