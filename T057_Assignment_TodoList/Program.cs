using System.Globalization;

List<string> todos = [];

PrintOptionsMenu(true);
bool isUserChoiceCorrect = false;
do
{
	string userChoice = Console.ReadLine() ?? String.Empty;
	switch (userChoice.ToUpper(CultureInfo.InvariantCulture))
	{
		case "S":
			Console.Clear();
			SeeAllToDos();
			break;
		case "A":
			Console.Clear();
			AddToDo();
			break;
		case "R":
			Console.Clear();
			RemoveToDo();
			break;
		case "E":
			Exit("End of application.");
			break;
		default:
			Console.Clear();
			Console.WriteLine("Invalid choice.");
			break;
	}

	PrintOptionsMenu();
} while (isUserChoiceCorrect is false);

void SeeAllToDos()
{
	Console.WriteLine("------------------------------------------------");

	if (todos.Count.Equals(0))
	{
		Console.WriteLine("No TODOs have been added yet.");
		return;
	}

	for (int i = 0; i < todos.Count; i++)
	{
		Console.WriteLine($"{i + 1}. {todos[i]}");
	}
}

void AddToDo()
{
	bool isTodoDescriptionCorrect = false;
	do
	{
		Console.WriteLine("Enter the TODO description:");
		string todoDescription = Console.ReadLine() ?? String.Empty;

		if (string.IsNullOrWhiteSpace(todoDescription))
		{
			Console.WriteLine("The description cannot be empty.");
			continue;
		}

		if (todos.Contains(todoDescription))
		{
			Console.WriteLine("The description must be unique.");
			continue;
		}

		todos.Add(todoDescription);
		Console.WriteLine($"TODO successfully added: {todoDescription}");

		isTodoDescriptionCorrect = true;
	} while (isTodoDescriptionCorrect is false);
}

void RemoveToDo()
{
	bool isTodoRemoveOperationCorrect = false;
	do
	{
		Console.WriteLine("Select the index of the TODO you want to remove:");
		SeeAllToDos();

		if (todos.Count.Equals(0))
		{
			return;
		}

		string todoIndexString = Console.ReadLine() ?? String.Empty;
		if (string.IsNullOrWhiteSpace(todoIndexString))
		{
			Console.WriteLine("Selected index cannot be empty.");
			continue;
		}

		bool isTodoIndexTryParse = int.TryParse(todoIndexString, out int todoIndex);
		if (isTodoIndexTryParse is false || todoIndex < 1 || todoIndex > todos.Count)
		{
			Console.WriteLine();
			Console.WriteLine("The given index is not valid.");
			continue;
		}

		Console.WriteLine($"TODO removed: {todos[todoIndex - 1]}");
		todos.RemoveAt(todoIndex - 1);
		isTodoRemoveOperationCorrect = true;
	} while (isTodoRemoveOperationCorrect is false);

	return;
}

static void PrintOptionsMenu(bool isStartOffAppp = false)
{
	Console.WriteLine();
	if (isStartOffAppp) Console.WriteLine("Hello!");

	Console.WriteLine("What do you want to do?");
	Console.WriteLine("[S]ee all TODO's");
	Console.WriteLine("[A]dd a TODO");
	Console.WriteLine("[R]emove TODO");
	Console.WriteLine("[E]xit");
}

static void Exit(string exitMessage, int exitCode = 0)
{
	Console.WriteLine("------------------------------------------------");
	Console.WriteLine($"{exitMessage} Press any key to close.");
	Console.ReadKey();
	System.Environment.Exit(exitCode);
}
