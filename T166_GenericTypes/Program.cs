//var points = CreateCollectionOfRandomLength<Point>(100);
var ints = CreateCollectionOfRandomLength<int>(100);
var dates = CreateCollectionOfRandomLength<DateTime>(100);

IEnumerable<T> CreateCollectionOfRandomLength<T>(int maxLength) where T : new()
{
	var length = new Random().Next(maxLength + 1);

	var result = new List<T>();

	for (int i = 0; i < length; i++)
	{
		result.Add(new T());
	}

	return result;
}

public class Point(int x, int y)
{
	public int X { get; } = x;
	public int Y { get; } = y;
}