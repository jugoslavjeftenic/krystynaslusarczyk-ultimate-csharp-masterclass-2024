
var numbers = new List<int> { 10, 12, -100, 55, 17, 22 };

Console.WriteLine("Select filter: Even, Odd, Positive");
var userInput = Console.ReadLine() ?? "";

List<int> result = new NumbersFilter().FilterBy(userInput, numbers);

Print(result);

void Print(IEnumerable<int> numbers)
{
	Console.WriteLine(string.Join(", ", numbers));
}

public class NumbersFilter
{
	public List<int> FilterBy(string filteringType, List<int> numbers)
	{
		switch (filteringType)
		{
			case "Even":
				return SelectEven(numbers);
			case "Odd":
				return SelectOdd(numbers);
			case "Positive":
				return SelectPositive(numbers);
			default:
				throw new NotSupportedException($"{filteringType} is not a valid filter");
		};
	}
	private List<int> SelectEven(List<int> numbers)
	{
		var result = new List<int>();

		foreach (var number in numbers)
		{
			if (number % 2 == 0) result.Add(number);
		}

		return result;
	}

	private List<int> SelectOdd(List<int> numbers)
	{
		var result = new List<int>();

		foreach (var number in numbers)
		{
			if (number % 2 == 1) result.Add(number);
		}

		return result;
	}

	private List<int> SelectPositive(List<int> numbers)
	{
		var result = new List<int>();

		foreach (var number in numbers)
		{
			if (number > 0) result.Add(number);
		}

		return result;
	}
}