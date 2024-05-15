var numbers = new SimpleList<int>();
numbers.Add(10);
numbers.Add(20);
numbers.Add(30);
numbers.Add(40);
numbers.Add(50);
numbers.RemoveAt(2);

var words = new SimpleList<string>();
words.Add("aaa");
words.Add("bbb");
words.Add("ccc");

class SimpleList<T>
{
	private T?[] _items = new T[4];
	private int _size = 0;

	public void Add(T item)
	{
		if (_size >= _items.Length)
		{
			var newItems = new T?[_items.Length * 2];

			for (int i = 0; i < _items.Length; i++)
			{
				newItems[i] = _items[i];
			}

			_items = newItems;
		}

		_items[_size] = item;
		++_size;
	}

	public void RemoveAt(int index)
	{
		if (index < 0 || index >= _size)
		{
			throw new IndexOutOfRangeException($"Index {index} is outside the bund of the list.");
		}

		--_size;

		for (int i = index; i < _size; ++i)
		{
			_items[i] = _items[i + 1];
		}

		_items[_size] = default;
	}

	public T? GetAtIndex(int index)
	{
		if (index < 0 || index >= _size)
		{
			throw new IndexOutOfRangeException($"Index {index} is outside the bund of the list.");
		}

		return _items[index];
	}
}