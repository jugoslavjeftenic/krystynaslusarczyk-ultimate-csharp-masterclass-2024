using System.Diagnostics;

//var points = CreateCollectionOfRandomLength<Point>(100);
//var ints = CreateCollectionOfRandomLength<int>(100);

Stopwatch stopwatch = Stopwatch.StartNew();

var dates = CreateCollectionOfRandomLength<DateTime>(100);

stopwatch.Stop();
Console.WriteLine($"Execution took {stopwatch.ElapsedMilliseconds} ms.");
// Result before optimization: ~1700ms.
// Result after optimization: ~1020ms.

IEnumerable<T> CreateCollectionOfRandomLength<T>(int maxLength) where T : new()
{
	var length = 100000000; // new Random().Next(maxLength + 1);

	//var result = new List<T>();
	var result = new List<T>(length);

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