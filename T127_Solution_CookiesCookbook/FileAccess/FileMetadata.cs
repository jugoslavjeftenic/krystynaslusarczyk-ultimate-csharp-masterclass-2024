namespace T127_Solution_CookiesCookbook.FileAccess;

public class FileMetadata(string name, FileFormat format)
{
	public string Name { get; } = name;
	public FileFormat Format { get; } = format;
	public string ToPath() => $"{Name}.{Format.AsFileExtension()}";
}
