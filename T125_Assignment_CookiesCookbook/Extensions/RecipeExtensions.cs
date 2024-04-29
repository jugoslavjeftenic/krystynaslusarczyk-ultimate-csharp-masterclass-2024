using System.Text.Json;
using T125_Assignment_CookiesCookbook.Models;
using T125_Assignment_CookiesCookbook.Repositories;

namespace T125_Assignment_CookiesCookbook.Extensions
{
	public static class RecipeExtensions
	{
		public static List<RecipeModel> ReadExistingRecipes(
			this List<RecipeModel> recipes,
			string fileName,
			string fileExtension,
			List<IngredientModel> ingredientsRepository
			)
		{
			string stringToDeserialize = ReadFile(fileName, fileExtension);

			if (string.IsNullOrWhiteSpace(stringToDeserialize) is false &&
				fileExtension.Equals("json", StringComparison.CurrentCultureIgnoreCase))
			{
				recipes.AddRange(JsonSerializer.Deserialize<List<RecipeModel>>(stringToDeserialize)!);
			}

			if (string.IsNullOrWhiteSpace(stringToDeserialize) is false &&
				fileExtension.Equals("txt", StringComparison.CurrentCultureIgnoreCase))
			{
				string[] arrayOfRecipes = stringToDeserialize.Split(Environment.NewLine);

				foreach (var singleRecipe in arrayOfRecipes)
				{
					if (singleRecipe.Equals(string.Empty))
					{
						continue;
					}

					string[] arrayOfStringIngredients = singleRecipe.Split(", ");
					int[] arrayOfIntIngredients = new int[arrayOfStringIngredients.Length];
					List<IngredientModel> ingredients = [];

					for (int i = 0; i < arrayOfStringIngredients.Length; i++)
					{
						if (int.TryParse(arrayOfStringIngredients[i], out arrayOfIntIngredients[i]))
						{
							ingredients.Add(IngredientsRepository.FindIngredient
								(arrayOfIntIngredients[i], ingredientsRepository)!);
						}
					}

					if (ingredients.Count > 0)
					{
						recipes.Add(new RecipeModel(ingredients));
					}
				}
			}

			return recipes;
		}

		public static void PrintExistingRecipes(this List<RecipeModel> recipes)
		{
			int counter = 0;
			Console.WriteLine("Existing recipes are:");
			Console.WriteLine();

			foreach (var recipe in recipes)
			{
				Console.WriteLine($"***** {++counter} *****");
				Console.WriteLine(recipe.ToString());
			}
		}

		public static void PrintLastRecipeIngredients(this List<RecipeModel> recipes)
		{
			if (recipes.Count > 0)
			{
				Console.WriteLine(recipes[^1].ToString());
			}
		}

		public static void SaveRecipes
			(this List<RecipeModel> recipes, string fileName, string fileExtension)
		{
			string stringToSerialize = string.Empty;

			if (fileExtension.Equals("json", StringComparison.CurrentCultureIgnoreCase))
			{
				stringToSerialize = JsonSerializer.Serialize(recipes);
			}
			else
			{
				foreach (var recipe in recipes)
				{
					string recipeToString = string.Empty;

					foreach (var ingredient in recipe.Ingredients)
					{
						recipeToString += $"{ingredient.ID}, ";
					}

					recipeToString = recipeToString[..(recipeToString.Length - 2)] +
						Environment.NewLine;

					stringToSerialize += recipeToString;
				}
			}

			using StreamWriter writeText = new($"{fileName}.{fileExtension}");
			writeText.Write(stringToSerialize);
		}

		private static string ReadFile(string fileName, string fileExtension)
		{
			if (File.Exists($"{fileName}.{fileExtension}"))
			{
				using StreamReader streamReader = new($"{fileName}.{fileExtension}");
				return streamReader.ReadToEnd();
			}

			return string.Empty;
		}
	}
}
