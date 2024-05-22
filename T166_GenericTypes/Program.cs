ProcessString processString1 = TrimTo5Letters;
ProcessString processString2 = ToUpper;

Console.WriteLine(processString1("Heloooooooooo"));
Console.WriteLine(processString2("Heloooooooooo"));

Print print1 = text => Console.WriteLine(text.ToUpper());
Print print2 = text => Console.WriteLine(text.ToLower());
Print multicast = print1 + print2;

Print print4 = text => Console.WriteLine(text.Substring(0, 4));
multicast += print4;

multicast("Crocodile");

Func<string, string, int> sumLengths = (text1, text2) => text1.Length + text2.Length;

string TrimTo5Letters(string input)
{
	return input.Substring(0, 5);
}

string ToUpper(string input)
{
	return input.ToUpper();
}

delegate string ProcessString(string input);
delegate void Print(string input);
