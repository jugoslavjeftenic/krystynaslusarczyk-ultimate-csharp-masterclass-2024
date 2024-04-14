Console.WriteLine("Hello!");

Console.WriteLine("Input first number: ");
if (int.TryParse(Console.ReadLine(), out int firstNumber) is false) BadInput("First number is incorrect!");

Console.WriteLine("Input second number");
if (int.TryParse(Console.ReadLine(), out int secondNumber) is false) BadInput("Second number is incorrect!");

Calculate();

void Calculate()
{
	Console.WriteLine("What do you want to do?");
	Console.WriteLine("[A]dd numbers");
	Console.WriteLine("[S]ubstract numbers");
	Console.WriteLine("[M]ultiply numbers");
	Console.WriteLine("[E]xit");

	string? menuChoice = Console.ReadLine();

	if (menuChoice!.Equals("A", StringComparison.OrdinalIgnoreCase))
	{
		Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
	}
	else if (menuChoice!.Equals("S", StringComparison.OrdinalIgnoreCase))
	{
		Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
	}
	else if (menuChoice!.Equals("M", StringComparison.OrdinalIgnoreCase))
	{
		Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
	}
	else if (menuChoice!.Equals("E", StringComparison.OrdinalIgnoreCase))
	{
		Console.WriteLine("Exiting application.");
		Exit(0);
	}
	else
	{
		BadInput("Incorrect menu choice!");
	}
}

static void BadInput(string message)
{
	Console.WriteLine(message);
	Exit(1);
}

static void Exit(int exitCode)
{
	Console.WriteLine("Press any key to close.");
	Console.ReadKey();
	System.Environment.Exit(exitCode);
}
