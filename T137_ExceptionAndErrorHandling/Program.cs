Console.WriteLine("Enter a number:");
string input = Console.ReadLine()!;

try
{
	int number = ParseStringToInt(input);
	var result = 10 / number;
	Console.WriteLine($"10 / {number} is " + result);
}
catch (DivideByZeroException ex)
{
	try
	{
		int.Parse("not an int");
	}
	catch (FormatException)
	{
		throw;
	}

	Console.WriteLine($"Division by zero is an invalid operation. " +
		$"Exception message: {ex.Message}");
}
catch (FormatException ex)
{
	Console.WriteLine($"Wrong format. Input string is not parsable to int. " +
		$"Exception message: {ex.Message}");
}
catch (Exception ex)
{
	Console.WriteLine($"Unexpected error occurred. " +
		$"Exception message: {ex.Message}");
}
finally
{
	Console.WriteLine("Finally block is being executed.");
}

static int ParseStringToInt(string input)
{
	return int.Parse(input);
}