using T127_Solution_CookiesCookbook.App;
using T127_Solution_CookiesCookbook.DataAccess;
using T127_Solution_CookiesCookbook.FileAccess;
using T127_Solution_CookiesCookbook.Recipes;
using T127_Solution_CookiesCookbook.Recipes.Ingredients;

const FileFormat Format = FileFormat.Json;
IStringsRepository stringsRepository =
	Format.Equals(FileFormat.Json) ? new StringsJsonRepository() : new StringsTextualRepository();

const string FileName = "recipes";
var fileMetadata = new FileMetadata(FileName, Format);

var ingredientsRegister = new IngredientsRegister();

var cookiesRecipesApp = new CookiesRecipesApp
	(
		new RecipesRepository(
			   stringsRepository,
			   ingredientsRegister),
		new RecipesConsoleUserInteraction(ingredientsRegister)
	);

cookiesRecipesApp.Run(fileMetadata.ToPath());
