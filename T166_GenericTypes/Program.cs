
var numbers = new List<int> { 10, 12, -100, 55, 17, 22 };

Console.WriteLine("Select filter: Even, Odd, Positive");
var userInput = Console.ReadLine() ?? "";

var filteringStrategy = new FilteringStrategySelector().Select(userInput);
List<int> result = new NumbersFilter().FilterBy(filteringStrategy, numbers);

Print(result);

void Print(IEnumerable<int> numbers)
{
	Console.WriteLine(string.Join(", ", numbers));
}

public class NumbersFilter
{
	public List<int> FilterBy(Func<int, bool> predicate, List<int> numbers)
	{
		var result = new List<int>();

		foreach (var number in numbers)
		{
			if (predicate(number)) result.Add(number);
		}

		return result;
	}

}
public class FilteringStrategySelector
{
	private readonly Dictionary<string, Func<int, bool>> _filteringStrategies =
		new Dictionary<string, Func<int, bool>>()
		{
			["Even"] = number => number % 2 == 0,
			["Odd"] = number => number % 2 == 1,
			["Positive"] = number => number > 0
		};

	public Func<int, bool> Select(string filteringType)
	{
		if (_filteringStrategies.ContainsKey(filteringType) is false)
		{
			throw new NotSupportedException($"{filteringType} is not a valid filter");
		}

		return _filteringStrategies[filteringType];
	}
}
