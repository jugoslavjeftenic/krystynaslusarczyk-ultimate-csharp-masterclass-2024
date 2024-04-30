using T127_Solution_CookiesCookbook.Recipes.Ingredients;

namespace T127_Solution_CookiesCookbook
{
	public class IngredientsRegister : IIngredientsRegister
	{
		public IEnumerable<Ingredient> All { get; } =
		[
			new WheatFlour(),
			new SpeltFlour(),
			new Butter(),
			new Chocolate(),
			new Sugar(),
			new Cardamom(),
			new Cinnamon(),
			new CocoaPowder()
		];

		public Ingredient? GetById(int id)
		{
			foreach (var ingredient in All)
			{
				if (ingredient.Id.Equals(id))
				{
					return ingredient;
				}
			}

			return null;
		}
	}
}