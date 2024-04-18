var pizza = new Pizza();
pizza.AddIngredient(new Cheddar());
pizza.AddIngredient(new TomatoSauce());
pizza.AddIngredient(new Mozzarella());

Console.WriteLine(pizza.Describe());

var cheddar = new Cheddar();
Console.WriteLine(cheddar.PublicMethod());
//Console.WriteLine(cheddar.ProtectedMethod());
//Console.WriteLine(cheddar.PrivateMethod());


public class Pizza
{
	private readonly List<Ingredients> _ingredients = [];

	public void AddIngredient(Ingredients ingredient) => _ingredients.Add(ingredient);

	public string Describe() => $"This is a pizza with {string.Join(", ", _ingredients)}.";
}

public class Ingredients()
{
	public string PublicMethod() => "This method is PUBLIC in the Ingredient class.";
	protected string ProtectedMethod() => "This method is PROTECTED in the Ingredient class.";
	private string PrivateMethod() => "This method is PRIVATE in the Ingredient class.";
}

public class Cheddar : Ingredients
{
	public string Name => "Cheddar chees";
	public int AgedForMonths { get; }

	public void UseMethodsFromBaseClass()
	{
		Console.WriteLine(PublicMethod());
		Console.WriteLine(ProtectedMethod());
		//Console.WriteLine(PrivateMethod());
	}
}

public class TomatoSauce : Ingredients
{
	public string Name => "TomatoSauce";
	public int TomatoesIn100Grams { get; }
}

public class Mozzarella : Ingredients
{
	public string Name => "Mozzarella";
	public bool IsLight { get; }
}
