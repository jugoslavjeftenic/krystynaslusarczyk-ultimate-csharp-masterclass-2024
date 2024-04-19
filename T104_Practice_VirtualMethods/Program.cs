
var numbers = new List<int> { 1, 4, 6, -1, 12, 44, -8, -19 };
bool shallAddPositiveOnly = true;

NumbersSumCalculator calculator = shallAddPositiveOnly ?
	new PositiveNumbersSumCalculator() :
	new NumbersSumCalculator();

int sum = calculator.Calculate(numbers);
Console.WriteLine("Sum is: " + sum);

public class NumbersSumCalculator
{
	public int Calculate(List<int> numbers)
	{
		int sum = 0;
		foreach (var number in numbers)
		{
			if (ShallBeAdded(number))
			{
				sum += number;
			}
		}
		return sum;
	}

	protected virtual bool ShallBeAdded(int number)
	{
		return true;
	}
}

public class PositiveNumbersSumCalculator : NumbersSumCalculator
{
	protected override bool ShallBeAdded(int number)
	{
		return number > 0;
	}
}
