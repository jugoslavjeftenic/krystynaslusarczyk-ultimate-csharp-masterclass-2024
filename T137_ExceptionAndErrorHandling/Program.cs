IsFirstElementPositive(new int[] { 1, 2, 3 });

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
		throw new InvalidOperationException("The collection is empty!", ex);
	}
	catch (NullReferenceException ex)
	{
		throw new ArgumentNullException("The collection is null.", ex);
	}
}
