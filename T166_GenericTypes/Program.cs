var numbers = new[] { 1, 4, 7, 19, 2 };

// Func<int, DateTime, string, decimal> someFunc; ;
// Action<string, string, bool> someAction; ;

Func<int, bool> predicate1 = IsLargerThen10;
Console.WriteLine("IsAnyLargerThen10? " + IsAny(numbers, predicate1));
Console.WriteLine("IsAnyLargerThen10? " + IsAny(numbers, IsLargerThen10));

// Lambda expression
Console.WriteLine("IsAnyLargerThen10? " + IsAny(numbers, n => n > 10));

Func<int, bool> predicate2 = IsEven;
Console.WriteLine("IsAnyEvan? " + IsAny(numbers, predicate2));
Console.WriteLine("IsAnyEvan? " + IsAny(numbers, IsEven));

// Lambda expression
Console.WriteLine("IsAnyEvan? " + IsAny(numbers, n => n % 2 == 0));

bool IsLargerThen10(int number)
{
	return number > 10;
}

bool IsEven(int number)
{
	return number % 2 == 0;
}

bool IsAny(IEnumerable<int> numbers, Func<int, bool> predicate)
{
	foreach (int number in numbers)
	{
		if (predicate(number))
		{
			return true;
		}
	}

	return false;
}
