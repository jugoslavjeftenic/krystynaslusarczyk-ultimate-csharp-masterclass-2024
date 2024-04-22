using T099_OOP.Extensions;

var pizza = new Pizza();
pizza.AddIngredient(new Cheddar(1, 12));
pizza.AddIngredient(new TomatoSauce(2));
pizza.AddIngredient(new Mozzarella(3));

Console.WriteLine(pizza.ToString());

Cheddar cheddar = new(1, 12);
Console.WriteLine(cheddar.PublicMethod());
//Console.WriteLine(cheddar.ProtectedMethod());
//Console.WriteLine(cheddar.PrivateMethod());

Ingredient ingredient = new Cheddar(1, 12);
Console.WriteLine("Variable of type Ingredient");
Console.WriteLine(ingredient.Name);

Console.WriteLine("Variable of type Cheddar");
Console.WriteLine(cheddar.Name);

Console.WriteLine();
var ingredients = new List<Ingredient>()
{
	new Cheddar(1, 12),
	new TomatoSauce(2),
	new Mozzarella(3)
};
foreach (var item in ingredients)
{
	Console.WriteLine(item.Name);
}

Console.WriteLine();
Console.WriteLine(cheddar);

Ingredient randomIngredient = GenerateRandomIngredient();
Console.WriteLine("Random ingredient is" + randomIngredient);

Console.WriteLine("is object? " + (randomIngredient is object));
Console.WriteLine("is ingredient? " + (randomIngredient is Ingredient));
Console.WriteLine("is cheddar? " + (randomIngredient is Cheddar));
Console.WriteLine("is tomato sauce? " + (randomIngredient is TomatoSauce));
Console.WriteLine("is mozzarella? " + (randomIngredient is Mozzarella));

if (randomIngredient is Cheddar cheddar1)
{
	Console.WriteLine("cheddar object: " + cheddar1);
}

Console.WriteLine();
Console.WriteLine("Extension methods:");
var multilineText = @"aaaaa
bbbbb
cccc
ddddd";
Console.WriteLine("Count of lines is " + multilineText.CountLines());
Console.WriteLine("Next after Spring is " + Season.Spring.Next());
Console.WriteLine("Next after Winter is " + Season.Winter.Next());

var bakeableDishes = new List<IBakeable>()
{
	new Pizza(),
	new Panettone()
};

foreach (var bakeableDish in bakeableDishes)
{
	Console.WriteLine(bakeableDish.GetInstructions());
}

Ingredient GenerateRandomIngredient()
{
	var random = new Random();
	var number = random.Next(1, 4);
	if (number == 1) return new Cheddar(2, 12);
	if (number == 2) return new TomatoSauce(1);
	else return new Mozzarella(2);
}

public abstract class Dessert
{

}

public interface IBakeable
{
	string GetInstructions();
}

public class Panettone : Dessert, IBakeable
{
	public string GetInstructions() => "Bake at 180 degrees Celsius for 35 minutes.";
}

public class Pizza : IBakeable
{
	private readonly List<Ingredient> _ingredients = [];
	public void AddIngredient(Ingredient ingredient) => _ingredients.Add(ingredient);

	public string GetInstructions() => "Bake at 250 degrees Celsius for 10 minutes.";

	public override string ToString() => $"This is a pizza with {string.Join(", ", _ingredients)}.";
}

public abstract class Ingredient(int priceIfExtraTopping)
{
	public int PriceIfExtraTopping { get; } = priceIfExtraTopping;
	public override string ToString() => Name;
	public virtual string Name { get; } = "Some ingredient";
	public string PublicMethod() => "This method is PUBLIC in the Ingredient class.";
	protected string ProtectedMethod() => "This method is PROTECTED in the Ingredient class.";
	private string PrivateMethod() => "This method is PRIVATE in the Ingredient class.";
}

public class Cheese(int priceIfExtraTopping) : Ingredient(priceIfExtraTopping)
{
}

public class Cheddar(int priceIfExtraTopping, int agedForMonths) : Cheese(priceIfExtraTopping)
{
	public override string Name =>
		$"{base.Name}, more specifically, a Cheddar chees aged for {agedForMonths} months.";
	//public string Name => "Cheddar chees";

	public int AgedForMonths { get; }

	public void UseMethodsFromBaseClass()
	{
		Console.WriteLine(PublicMethod());
		Console.WriteLine(ProtectedMethod());
		//Console.WriteLine(PrivateMethod());
	}
}

public class TomatoSauce(int priceIfExtraTopping) : Ingredient(priceIfExtraTopping)
{
	public override string Name => "TomatoSauce";
	public int TomatoesIn100Grams { get; }
}

public class Mozzarella(int priceIfExtraTopping) : Cheese(priceIfExtraTopping)
{
	public override string Name => "Mozzarella";
	public bool IsLight { get; }
}

public enum Season
{
	Spring,
	Summer,
	Autumn,
	Winter
}