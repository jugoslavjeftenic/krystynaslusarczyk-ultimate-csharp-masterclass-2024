namespace T127_Solution_CookiesCookbook
{
	public class FileMetadata(string name, FileFormat format)
	{
		public string Name { get; } = name;
		public FileFormat Format { get; } = format;
		public string ToPath() => $"{Name}.{Format.AsFileExtension()}";
	}
}
