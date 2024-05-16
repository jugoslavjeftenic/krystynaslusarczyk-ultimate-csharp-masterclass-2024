

var numbers = new List<int> { 5, 3, 2, 8, 16, 7 };
Tuple<int, int> minAndMax = GetMinAndMax(numbers);

var twoStrings = new Tuple<string, string>("aaa", "bbb");
var differentTypes = new Tuple<string, int>("aaa", 1);
var threeTypes = new Tuple<string, int, bool>("aaa", 1, false);

Console.WriteLine("Smallest number is " + minAndMax.Item1);
Console.WriteLine("Largest number is " + minAndMax.Item2);

Tuple<int, int> GetMinAndMax(IEnumerable<int> input)
{
	if (input.Any() is false)
	{
		throw new InvalidOperationException("The input collection cannot be empty.");
	}

	int min = input.First();
	int max = input.First();

	foreach (var number in input)
	{
		if (number > max)
		{
			max = number;
		}
		if (number < min)
		{
			min = number;
		}
	}

	return new Tuple<int, int>(min, max);
}

//public class SimpleTuple<T1, T2>(T1 item1, T2 item2)
//{
//	public T1 Item1 { get; } = item1;
//	public T2 Item2 { get; } = item2;
//}

//public class SimpleTuple<T1, T2, T3>(T1 item1, T2 item2, T3 item3)
//{
//	public T1 Item1 { get; } = item1;
//	public T2 Item2 { get; } = item2;
//	public T3 Item3 { get; } = item3;
//}
