namespace T092_Assignment_DiceRollGame
{
	public static class ConsoleReader
	{
		public static int ReadInteger(string message)
		{
			int result;

			do
			{
				Console.WriteLine(message);
			} while (int.TryParse(Console.ReadLine(), out result) is false);

			return result;
		}
	}
}
