RecursiveMethod(1);

static void RecursiveMethod(int counter)
{
	Console.WriteLine($"I'm going to call myself. Counter is: {counter}");
	if (counter < 10)
	{
		RecursiveMethod(counter + 1);
	}
}
