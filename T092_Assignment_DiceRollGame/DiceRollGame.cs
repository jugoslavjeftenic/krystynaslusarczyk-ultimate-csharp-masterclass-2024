
namespace T092_Assignment_DiceRollGame
{
	public class DiceRollGame(Dice dice)
	{
		public int InitialTries { get; } = 3;

		public GameResult Play()
		{
			int diceRoleResult = dice.Roll();
			int triesLeft = InitialTries;

			Console.WriteLine($"Dice rolled. Guess what number it shows in {InitialTries} tries.");
			while (triesLeft > 0)
			{
				var guess = ConsoleReader.ReadInteger("Enter a number:");

				if (guess.Equals(diceRoleResult))
				{
					return GameResult.Victory;
				}

				Console.WriteLine("Wrong number.");
				triesLeft--;
			}

			return GameResult.Loss;
		}

		public static void PrintResult(GameResult gameResult)
		{
			string message = gameResult.Equals(GameResult.Victory) ? "You win." : "You lose.";

			Console.WriteLine(message);
		}
	}
}
