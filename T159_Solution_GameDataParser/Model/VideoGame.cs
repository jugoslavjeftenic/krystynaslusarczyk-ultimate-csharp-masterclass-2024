namespace T159_Solution_GameDataParser.Model;

public class VideoGame
{
	public string Title { get; init; } = string.Empty;
	public int ReleaseYear { get; init; }
	public decimal Rating { get; init; }

	public override string ToString() => $"{Title}, released in {ReleaseYear}, rating {Rating}";
}