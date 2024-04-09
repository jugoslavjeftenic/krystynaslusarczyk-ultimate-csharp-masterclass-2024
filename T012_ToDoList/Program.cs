Console.WriteLine("Hello!");
Console.WriteLine("What do you want to do?");

Console.WriteLine("[S]ee all TODO's");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove TODO");
Console.WriteLine("[E]xit");

string userChoice = Console.ReadLine() ?? "";

if (userChoice.Equals("S", StringComparison.OrdinalIgnoreCase))
{
	PrintSelectedOption("See all TODOs");
}
else if (userChoice.Equals("A", StringComparison.OrdinalIgnoreCase))
{
	PrintSelectedOption("Add a TODOs");
}
else if (userChoice.Equals("R", StringComparison.OrdinalIgnoreCase))
{
	PrintSelectedOption("Remove a TODOs");
}
else if (userChoice.Equals("E", StringComparison.OrdinalIgnoreCase))
{
	PrintSelectedOption("EXIT");
}

Console.ReadKey();

static void PrintSelectedOption(string selectedOption)
{
	Console.WriteLine($"Selected option: {selectedOption}");
}
