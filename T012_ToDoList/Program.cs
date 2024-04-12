using System.Globalization;

Console.WriteLine("Hello!");
Console.WriteLine("What do you want to do?");

Console.WriteLine("[S]ee all TODO's");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove TODO");
Console.WriteLine("[E]xit");

string userChoice = Console.ReadLine() ?? String.Empty;
switch (userChoice.ToUpper(CultureInfo.InvariantCulture))
{
	case "S":
		PrintSelectedOption("See all TODOs");
		break;
	case "A":
		PrintSelectedOption("Add a TODOs");
		break;
	case "R":
		PrintSelectedOption("Remove a TODOs");
		break;
	case "E":
		PrintSelectedOption("EXIT");
		break;
	default:
		Console.WriteLine("Invalid choice.");
		break;
}

Console.ReadKey();

static void PrintSelectedOption(string selectedOption)
{
	Console.WriteLine($"Selected option: {selectedOption}");
}
