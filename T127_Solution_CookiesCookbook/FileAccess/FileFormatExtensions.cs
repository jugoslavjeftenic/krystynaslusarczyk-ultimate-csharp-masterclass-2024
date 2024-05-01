namespace T127_Solution_CookiesCookbook.FileAccess;

public static class FileFormatExtensions
{
	public static string AsFileExtension(this FileFormat fileFormat) =>
		fileFormat.Equals(FileFormat.Json) ? "json" : "txt";
}
