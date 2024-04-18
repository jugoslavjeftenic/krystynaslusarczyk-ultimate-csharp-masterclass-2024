var pizza = new Pizza();
pizza.AddIngredient(new Cheddar());
pizza.AddIngredient(new TomatoSauce());
pizza.AddIngredient(new Mozzarella());

Console.WriteLine(pizza.Describe());

Cheddar cheddar = new();
Console.WriteLine(cheddar.PublicMethod());
//Console.WriteLine(cheddar.ProtectedMethod());
//Console.WriteLine(cheddar.PrivateMethod());

Ingredient ingredient = new Cheddar();
Console.WriteLine("Variable of type Ingredient");
Console.WriteLine(ingredient.Name);

Console.WriteLine("Variable of type Cheddar");
Console.WriteLine(cheddar.Name);

Console.WriteLine();
var ingredients = new List<Ingredient>()
{
	new Cheddar(),
	new TomatoSauce(),
	new Mozzarella()
};
foreach (var item in ingredients)
{
	Console.WriteLine(item.Name);
}

public class Pizza
{
	private readonly List<Ingredient> _ingredients = [];

	public void AddIngredient(Ingredient ingredient) => _ingredients.Add(ingredient);

	public string Describe() => $"This is a pizza with {string.Join(", ", _ingredients)}.";
}

public class Ingredient()
{
	public virtual string Name { get; } = "Some ingredient";
	public string PublicMethod() => "This method is PUBLIC in the Ingredient class.";
	protected string ProtectedMethod() => "This method is PROTECTED in the Ingredient class.";
	private string PrivateMethod() => "This method is PRIVATE in the Ingredient class.";
}

public class Cheddar : Ingredient
{
	public override string Name => "Cheddar chees";
	//public string Name => "Cheddar chees";
	public int AgedForMonths { get; }

	public void UseMethodsFromBaseClass()
	{
		Console.WriteLine(PublicMethod());
		Console.WriteLine(ProtectedMethod());
		//Console.WriteLine(PrivateMethod());
	}
}

public class TomatoSauce : Ingredient
{
	public override string Name => "TomatoSauce";
	public int TomatoesIn100Grams { get; }
}

public class Mozzarella : Ingredient
{
	public override string Name => "Mozzarella";
	public bool IsLight { get; }
}
