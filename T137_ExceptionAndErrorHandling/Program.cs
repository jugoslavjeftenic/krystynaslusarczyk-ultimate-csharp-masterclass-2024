Console.WriteLine("Enter a number:");
string input = Console.ReadLine() ?? "";

try
{
	int number = ParseStringToInt(input);
	Console.WriteLine("String successfully parsed, the result is" + number);
}
catch (Exception ex)
{
	Console.WriteLine($"An exception was thrown. Exception message: {ex.Message}");
}
finally
{
	Console.WriteLine("Finally block is being executed.");
}

int ParseStringToInt(string input)
{
	return int.Parse(input);
}
