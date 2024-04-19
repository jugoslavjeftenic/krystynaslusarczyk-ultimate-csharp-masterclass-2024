var pizza = new Pizza();
pizza.AddIngredient(new Cheddar());
pizza.AddIngredient(new TomatoSauce());
pizza.AddIngredient(new Mozzarella());

Console.WriteLine(pizza.ToString());

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

Console.WriteLine();
Console.WriteLine(cheddar);

public class Pizza
{
	private readonly List<Ingredient> _ingredients = [];
	public void AddIngredient(Ingredient ingredient) => _ingredients.Add(ingredient);
	public override string ToString() => $"This is a pizza with {string.Join(", ", _ingredients)}.";
}

public class Ingredient()
{
	public override string ToString() => Name;
	public virtual string Name { get; } = "Some ingredient";
	public string PublicMethod() => "This method is PUBLIC in the Ingredient class.";
	protected string ProtectedMethod() => "This method is PROTECTED in the Ingredient class.";
	private string PrivateMethod() => "This method is PRIVATE in the Ingredient class.";
}

public class Cheese : Ingredient
{

}

public class Cheddar : Cheese
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

public class Mozzarella : Cheese
{
	public override string Name => "Mozzarella";
	public bool IsLight { get; }
}
