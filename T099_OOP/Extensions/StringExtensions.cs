namespace T099_OOP.Extensions
{
	public static class StringExtensions
	{
		public static int CountLines(this string input) => input.Split(Environment.NewLine).Length;
	}
}
