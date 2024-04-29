namespace T127_Solution_CookiesCookbook
{
	public class RecipesConsoleUserInteraction : IRecipesUserInteraction
	{
		public void ShowMessage(string message)
		{
			Console.WriteLine(message);
		}

		public void Exit()
		{
			Console.WriteLine("Press any key to close.");
			Console.ReadKey();
		}
	}
}