var john = new Person { Name = "John", YearOfBirth = 1980 };
var anna = new Person { Name = "Anna", YearOfBirth = 1915 };

PrintInOrder(10, 5);
PrintInOrder("aaa", "bbb");
PrintInOrder(anna, john);

void PrintInOrder<T>(T first, T second) where T : IComparable<T>
{
	if (first.CompareTo(second) > 0)
	{
		Console.WriteLine($"{second} {first}");
	}
	else
	{
		Console.WriteLine($"{first} {second}");
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
