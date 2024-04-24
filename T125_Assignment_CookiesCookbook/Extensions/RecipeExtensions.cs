using System.Text.Json;
using T125_Assignment_CookiesCookbook.Models;

namespace T125_Assignment_CookiesCookbook.Extensions
{
	public static class RecipeExtensions
	{
		public static void PrintIngredients(this List<IngredientModel> ingredients)
		{
			foreach (var ingredient in ingredients)
			{
				Console.WriteLine($"{ingredient.Name}. {ingredient.PreparationInstructions}");
			}
		}

		public static void SaveRecipes
			(this List<IngredientModel> ingredients, string fileName, FileFormat fileFormat)
		{
			string fileExtension;
			string lineToWrite;

			if (fileFormat == FileFormat.Json)
			{
				fileExtension = "json";

				RecipeModel newRecipe = new(ingredients);
				lineToWrite = JsonSerializer.Serialize(newRecipe);
			}
			else
			{
				fileExtension = "txt";
				lineToWrite = string.Empty;
				foreach (var ingredient in ingredients)
				{
					lineToWrite += $"{ingredient.ID}, ";
				}
				lineToWrite = lineToWrite[..(lineToWrite.Length - 2)] + Environment.NewLine;
			}

			using StreamWriter writeText = new($"{fileName}.{fileExtension}", true);
			writeText.Write(lineToWrite);
		}

		public static void ReadRecipes
			(this List<IngredientModel> ingredients, string fileName, FileFormat fileFormat)
		{
			//using (StreamReader readText = new StreamReader("readme.txt"))
			//{
			//	string readText = readText.ReadLine();
			//}
		}
	}
}
