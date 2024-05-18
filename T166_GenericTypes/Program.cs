// GenericUriParser methods
var ints = new List<int> { 1, 2, 3 };
ints.AddToFront(10);

// Generic methods with multiple type of parameters
var decimals = new List<decimal> { 1.1m, 0.5m, 22.5m, 12m };
var intsFromDecimals = decimals.ConvertTo<decimal, int>();

var floats = new List<float> { 1.4f, -100.01f };
var longsFromFloats = floats.ConvertTo<float, long>();

static class ListExtensions
{
	public static void AddToFront<T>(this List<T> list, T item)
	{
		list.Insert(0, item);
	}

	public static List<TTarget?> ConvertTo<TSource, TTarget>(this List<TSource> input)
	{
		var result = new List<TTarget?>();

		foreach (var item in input)
		{
			TTarget? itemAfterCasting = (TTarget?)Convert.ChangeType(item, typeof(TTarget));
			result.Add(itemAfterCasting);
		}

		return result;
	}
}
