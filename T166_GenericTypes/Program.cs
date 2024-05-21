var numbers = new List<int> { 5, 1, 7, 2 };
numbers.Sort();
PrintListToConsole(numbers);

var words = new List<string> { "ddd", "aaa", "ccc", "bbb" };
words.Sort();
PrintListToConsole(words);

var people = new List<Person>
{
	new() { Name = "John", YearOfBirth = 1980 },
	new() { Name = "Anna", YearOfBirth = 1915 },
	new() { Name = "Bill", YearOfBirth = 2011 }
};
people.Sort();
PrintListToConsole(people);

static void PrintListToConsole<T>(List<T> list)
{
	foreach (var item in list)
	{
		Console.WriteLine(item);
	}
}

public class Person : IComparable<Person>
{
	public string? Name { get; init; }
	public int YearOfBirth { get; init; }

	public int CompareTo(Person? other)
	{
		if (YearOfBirth < other?.YearOfBirth)
		{
			return 1;
		}
		else if (YearOfBirth > other?.YearOfBirth)
		{
			return -1;
		}
		return 0;
	}

	public override string ToString()
	{
		return $"{YearOfBirth}, {Name}";
	}
}
