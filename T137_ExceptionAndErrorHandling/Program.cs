try
{
	var result = IsFirstElementPositive(null!);
}
catch (NullReferenceException)
{

}

static int GetFirstElement(IEnumerable<int> numbers)
{
	Console.WriteLine("Finally block is being executed.");
	foreach (int number in numbers)
	{
		return number;
	}

	throw new InvalidOperationException("The collection cannot be empty.");
}

static bool IsFirstElementPositive(IEnumerable<int> numbers)
{
	try
	{
		var firstElement = GetFirstElement(numbers);
		return firstElement > 0;
	}
	catch (InvalidOperationException ex)
	{
		Console.WriteLine("The collection is empty!");
		Console.WriteLine(ex);
		return true;
	}
	catch (NullReferenceException ex)
	{
		//Console.WriteLine("Sorry, the application experienced an unexpected error.");
		//throw;
		throw new ArgumentNullException("The collection is null.", ex);
	}
}
