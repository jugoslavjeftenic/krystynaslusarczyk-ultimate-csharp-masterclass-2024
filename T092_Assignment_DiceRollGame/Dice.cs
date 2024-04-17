namespace T092_Assignment_DiceRollGame
{
	public class Dice(Random random)
	{
		public int SidesCount { get; } = 6;

		public int Roll() => random.Next(1, SidesCount + 1);
	}
}
