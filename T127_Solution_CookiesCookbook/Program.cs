using T127_Solution_CookiesCookbook;
using T127_Solution_CookiesCookbook.Repositories;

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
